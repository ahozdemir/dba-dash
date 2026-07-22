using DBAHawkGUI.SchemaCompare;
using DBAHawkGUI.Theme;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DBAHawkGUI
{
    public class CodeViewer : CodeEditorForm
    {
        public CodeViewer()
        {
            EditEnabled = false;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CodeEditor.CodeEditorModes Language
        {
            get => Syntax;
            set => Syntax = value;
        }
    }
}