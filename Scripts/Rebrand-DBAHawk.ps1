# ==============================================================
# DBA Hawk -> DBA Hawk Brand Migration Script
# Company : datacomware
# Author  : Ahmet Ozdemir
# Run from: repository root
# Usage   : .\Scripts\Rebrand-DBAHawk.ps1
#           Add -WhatIf to preview without writing
# ==============================================================

[CmdletBinding(SupportsShouldProcess)]
param(
    [string]$RepoRoot = (Get-Location).Path,
    [switch]$SkipFolderRenames
)

$ErrorActionPreference = "Stop"
Set-Location $RepoRoot

function Write-Step($msg) { Write-Host "`n=== $msg ===" -ForegroundColor Cyan }
function Write-Ok($msg)   { Write-Host "  [OK] $msg"   -ForegroundColor Green }
function Write-Warn($msg) { Write-Host "  [!!] $msg"   -ForegroundColor Yellow }

# --------------------------------------------------------------
# PHASE 1 - Text replacements across source files
# Order matters: most specific patterns first
# --------------------------------------------------------------
Write-Step "Phase 1 - Text replacements"

$replacements = [ordered]@{
    'Copyright .+ datacomware\.'                 = 'Copyright (c) 2026 datacomware'
    '"datacomware"'                              = '"datacomware"'
    'datacomware'                                = 'datacomware'
    '"DBA Hawk"'                                  = '"DBA Hawk"'
    'DBA Hawk'                                    = 'DBA Hawk'
    'DBA-Hawk'                                    = 'DBA-Hawk'
    'HawkBlueDark'                             = 'HawkBlueDark'
    'HawkBlue'                                 = 'HawkBlue'
    'HawkYellow'                               = 'HawkYellow'
    'HawkGray'                                 = 'HawkGray'
    'https://modus\.trimble\.com/foundations/color-palette/' = 'https://github.com/datacomware/dba-hawk'
    '\bDashColors\b'                              = 'HawkColors'
    '\bDBADashSharedGUI\b'                        = 'DBAHawkSharedGUI'
    '\bDBADashServiceConfig\b'                    = 'DBAHawkServiceConfig'
    '\bDBADashService\b'                          = 'DBAHawkService'
    '\bDBADashConfigTool\b'                       = 'DBAHawkConfigTool'
    '\bDBADashConfig\b'                           = 'DBAHawkConfig'
    '\bDBADashGUI\b'                              = 'DBAHawkGUI'
    '\bDBADashAI\b'                               = 'DBAHawkAI'
    '\bDBADashDB\b'                               = 'DBAHawkDB'
    'DBAHawk\.Test'                               = 'DBAHawk.Test'
    '\bDBADash\b'                                 = 'DBAHawk'
    'dbahawkconfig'                               = 'dbahawkconfig'
    'Ahmet Ozdemir'                               = 'Ahmet Ozdemir'
    'ahmetozdemir'                                = 'ahmetozdemir'
}

$extensions = @(
    "*.cs","*.csproj","*.sln","*.props","*.targets","*.DotSettings",
    "*.json","*.config","*.xml","*.yml","*.yaml","*.xaml",
    "*.md","*.txt","*.sql","*.ps1","*.sh"
)

$allFiles = Get-ChildItem -Path $RepoRoot -Recurse -Include $extensions |
    Where-Object { $_.FullName -notmatch '\\\.git\\' -and $_.FullName -notmatch '/\.git/' }

$totalChanged = 0

foreach ($file in $allFiles) {
    try {
        $raw = [System.IO.File]::ReadAllText($file.FullName, [System.Text.Encoding]::UTF8)
    } catch {
        Write-Warn "Cannot read (skipping): $($file.Name)"
        continue
    }

    $updated = $raw
    foreach ($kv in $replacements.GetEnumerator()) {
        $updated = [regex]::Replace($updated, $kv.Key, $kv.Value)
    }

    if ($updated -ne $raw) {
        if ($PSCmdlet.ShouldProcess($file.FullName, "Update branding text")) {
            [System.IO.File]::WriteAllText($file.FullName, $updated, [System.Text.Encoding]::UTF8)
        }
        Write-Ok $file.FullName.Replace($RepoRoot, "")
        $totalChanged++
    }
}

Write-Host "`n  $totalChanged file(s) updated." -ForegroundColor Cyan

if ($SkipFolderRenames) {
    Write-Warn "Skipping folder/file renames (-SkipFolderRenames set)."
    exit 0
}

# --------------------------------------------------------------
# PHASE 2 - Solution file renames
# --------------------------------------------------------------
Write-Step "Phase 2 - Solution file renames"

$fileRenames = @(
    @{ Old = "DBAHawk.sln";             New = "DBAHawk.sln" },
    @{ Old = "DBAHawk.sln.DotSettings"; New = "DBAHawk.sln.DotSettings" }
)

foreach ($r in $fileRenames) {
    if (Test-Path $r.Old) {
        if ($PSCmdlet.ShouldProcess($r.Old, "git mv to $($r.New)")) {
            git mv $r.Old $r.New
        }
        Write-Ok "$($r.Old) -> $($r.New)"
    }
}

# --------------------------------------------------------------
# PHASE 3 - Rename folders (git mv)
# Specific subfolders first, then the core DBAHawk folder last
# --------------------------------------------------------------
Write-Step "Phase 3 - Folder renames"

$folderRenames = @(
    @{ Old = "DBAHawkSharedGUI";     New = "DBAHawkSharedGUI" },
    @{ Old = "DBAHawkServiceConfig"; New = "DBAHawkServiceConfig" },
    @{ Old = "DBAHawkService";       New = "DBAHawkService" },
    @{ Old = "DBAHawkConfigTool";    New = "DBAHawkConfigTool" },
    @{ Old = "DBAHawkConfig";        New = "DBAHawkConfig" },
    @{ Old = "DBAHawkGUI";           New = "DBAHawkGUI" },
    @{ Old = "DBAHawkAI";            New = "DBAHawkAI" },
    @{ Old = "DBAHawkDB";            New = "DBAHawkDB" },
    @{ Old = "DBADashReports";       New = "DBAHawkReports" },
    @{ Old = "DBAHawk.Test";         New = "DBAHawk.Test" },
    @{ Old = "DBAHawk";              New = "DBAHawk" }
)

foreach ($r in $folderRenames) {
    $oldPath = Join-Path $RepoRoot $r.Old
    if (Test-Path $oldPath -PathType Container) {
        if ($PSCmdlet.ShouldProcess($r.Old, "git mv to $($r.New)")) {
            git mv $r.Old $r.New
        }
        Write-Ok "$($r.Old)/ -> $($r.New)/"
    }
}

# --------------------------------------------------------------
# PHASE 4 - Rename .csproj files inside moved folders
# --------------------------------------------------------------
Write-Step "Phase 4 - .csproj file renames"

$csprojRenames = @(
    @{ Old = "DBAHawk\DBAHawk.csproj";                   New = "DBAHawk\DBAHawk.csproj" },
    @{ Old = "DBAHawkGUI\DBAHawkGUI.csproj";             New = "DBAHawkGUI\DBAHawkGUI.csproj" },
    @{ Old = "DBAHawkService\DBAHawkService.csproj";      New = "DBAHawkService\DBAHawkService.csproj" },
    @{ Old = "DBAHawkConfig\DBAHawkConfig.csproj";        New = "DBAHawkConfig\DBAHawkConfig.csproj" },
    @{ Old = "DBAHawkAI\DBAHawkAI.csproj";               New = "DBAHawkAI\DBAHawkAI.csproj" },
    @{ Old = "DBAHawkSharedGUI\DBAHawkSharedGUI.csproj"; New = "DBAHawkSharedGUI\DBAHawkSharedGUI.csproj" },
    @{ Old = "DBAHawk.Test\DBAHawk.Test.csproj";         New = "DBAHawk.Test\DBAHawk.Test.csproj" },
    @{ Old = "DBAHawkDB\DBADashDB.sqlproj";              New = "DBAHawkDB\DBAHawkDB.sqlproj" }
)

foreach ($r in $csprojRenames) {
    $oldPath = Join-Path $RepoRoot $r.Old
    if (Test-Path $oldPath) {
        if ($PSCmdlet.ShouldProcess($r.Old, "git mv to $($r.New)")) {
            git mv $r.Old $r.New
        }
        Write-Ok "$($r.Old) -> $($r.New)"
    }
}

# --------------------------------------------------------------
Write-Step "Migration complete"
Write-Host ""
Write-Host "  Manual steps remaining:" -ForegroundColor Yellow
Write-Host "  1. Replace icon/logo files (.ico .svg .bmp) in:" -ForegroundColor Yellow
Write-Host "       DBAHawkGUI\DatabaseUnknown_16x.ico" -ForegroundColor Yellow
Write-Host "       DBAHawkService\cmd.ico" -ForegroundColor Yellow
Write-Host "       DBAHawkConfig\cmd.ico" -ForegroundColor Yellow
Write-Host "       DBAHawkServiceConfig\services.ico" -ForegroundColor Yellow
Write-Host "       Assets\monitor_to_db.svg" -ForegroundColor Yellow
Write-Host "  2. dotnet build DBAHawk.sln" -ForegroundColor Yellow
Write-Host "  3. git add -A && git commit -m 'rebrand: DBA Hawk -> DBA Hawk (datacomware)'" -ForegroundColor Yellow
