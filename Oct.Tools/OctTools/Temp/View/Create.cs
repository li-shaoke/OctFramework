﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 11.0.0.0
//  
//     对此文件的更改可能会导致不正确的行为。此外，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Oct.Tools.Res.Temp.View
{
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using Oct.Tools.Plugin.CodeGenerator.Entity;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class Create : CreateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"@{
    ViewBag.Title = ""Create"";
    Layout = ""~/Views/Shared/_Modal.cshtml"";
}

@section PluginsJS {
    <script src=""~/assets/global/plugins/jquery-validation/js/jquery.validate.min.js""></script>
    <script src=""~/assets/global/plugins/jquery-validation/js/additional-methods.min.js""></script>
}

@using ");
            
            #line 17 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Models;\r\n\r\n@model ");
            
            #line 19 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("DTO\r\n\r\n<div class=\"container\">\r\n    @using (Html.BeginForm(\"Create\", \"");
            
            #line 22 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("\", FormMethod.Post, new { @class = \"J_FormValidate\" }))\r\n    {\r\n        <div clas" +
                    "s=\"form form-horizontal\">\r\n");
            
            #line 25 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"

	var ignoreFiledNames = ConfigurationManager.AppSettings["IgnoreFiledNames"].Split(',');

	foreach(FiledInfo filed in dt.FiledList) 
	{		
        if (filed.IsPk || ignoreFiledNames.Contains(filed.Name.ToLower()))
			continue;

            
            #line default
            #line hidden
            this.Write("            <div class=\"form-group\">\r\n                ");
            
            #line 34 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.IsAllowNull ? "<label class=\"col-xs-3 control-label\">" : "<label class=\"col-xs-3 control-label\"><i class=\"fa fa-asterisk required\"></i>"));
            
            #line default
            #line hidden
            
            #line 34 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.GetDisplayName()));
            
            #line default
            #line hidden
            this.Write("</label>\r\n                <div class=\"col-xs-5\">\r\n");
            
            #line 36 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"
 
	var controlHtml = new StringBuilder();
	var requiredCssName = filed.IsAllowNull ? string.Empty : " required";

	switch (filed.CSharpType.ToLower())
	{
		case "bool":
			controlHtml.AppendFormat("@Html.CheckBoxFor(p => p.{0})", filed.Name);
			break;

		case "decimal":
		case "int":
			controlHtml.AppendFormat("@Html.TextBoxFor(p => p.{0}, new {2} @class = \"form-control{1}\", number = true {3})", filed.Name, requiredCssName, "{", "}");
			break;

		case "guid":
			controlHtml.AppendFormat("@Html.DropDownListFor(p => p.{0}, (IEnumerable<SelectListItem>)this.ViewBag.{0}s, new {2} @class = \"form-control input-sm{1}\" {3})", filed.Name, requiredCssName, "{", "}");
			break;

		default:
			controlHtml.AppendFormat("@Html.TextBoxFor(p => p.{0}, new {2} @class = \"form-control{1}\" {3})", filed.Name, requiredCssName, "{", "}");
			break;
	}

            
            #line default
            #line hidden
            this.Write("                    ");
            
            #line 60 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controlHtml.ToString()));
            
            #line default
            #line hidden
            this.Write("\r\n                </div>\r\n                <label class=\"col-xs-4 help-inline J_Va" +
                    "lidateMsg\"></label>\r\n            </div>\r\n");
            
            #line 64 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"
 } 
            
            #line default
            #line hidden
            this.Write(@"
            <div class=""form-group"">
                <div class=""col-xs-9 col-xs-offset-3"">
                    <button type=""submit"" value=""新增"" class=""btn blue""><i class=""fa fa-plus""></i>&nbsp;新增</button>
                </div>
            </div>
        </div>
    }
</div>
");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "D:\Work\Code\OCT_Framework\Oct.Tools\Oct.Tools.Res\Temp\View\Create.tt"

private global::Oct.Tools.Plugin.CodeGenerator.Entity.CodeBaseInfo _dtField;

/// <summary>
/// Access the dt parameter of the template.
/// </summary>
private global::Oct.Tools.Plugin.CodeGenerator.Entity.CodeBaseInfo dt
{
    get
    {
        return this._dtField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool dtValueAcquired = false;
if (this.Session.ContainsKey("dt"))
{
    if ((typeof(global::Oct.Tools.Plugin.CodeGenerator.Entity.CodeBaseInfo).IsAssignableFrom(this.Session["dt"].GetType()) == false))
    {
        this.Error("参数“dt”的类型“Oct.Tools.Plugin.CodeGenerator.Entity.CodeBaseInfo”与传递到模板的数据的类型不匹配。");
    }
    else
    {
        this._dtField = ((global::Oct.Tools.Plugin.CodeGenerator.Entity.CodeBaseInfo)(this.Session["dt"]));
        dtValueAcquired = true;
    }
}
if ((dtValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("dt");
    if ((data != null))
    {
        if ((typeof(global::Oct.Tools.Plugin.CodeGenerator.Entity.CodeBaseInfo).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("参数“dt”的类型“Oct.Tools.Plugin.CodeGenerator.Entity.CodeBaseInfo”与传递到模板的数据的类型不匹配。");
        }
        else
        {
            this._dtField = ((global::Oct.Tools.Plugin.CodeGenerator.Entity.CodeBaseInfo)(data));
        }
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class CreateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}