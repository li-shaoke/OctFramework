﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 11.0.0.0
//  
//     对此文件的更改可能会导致不正确的行为。此外，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Oct.Tools.Host.Res.Temp
{
    using System.Linq;
    using System.Text;
    using Oct.Tools.Plugin.CodeGenerator.Entity;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class Controller : ControllerBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using AutoMapper;\r\nusing Microsoft.Practices.Unity;\r\nusing Oct.Framework.Entities" +
                    ".Entities;\r\nusing Oct.Framework.MvcExt.Base;\r\nusing Oct.Framework.MvcExt.Extisio" +
                    "ns;\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Web.Mvc;\r\nus" +
                    "ing ");
            
            #line 14 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Entities;\r\nusing ");
            
            #line 15 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Services;\r\nusing ");
            
            #line 16 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Web.Models;\r\n");
            
            #line 17 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"

	var pkType = string.Empty;
	var pkName = string.Empty;
	var pkFileds = dt.FiledList.Where(d => d.IsPk);

	if (pkFileds.Count() > 0)
	{
		pkType = pkFileds.First().CSharpType;	 
		pkName = pkFileds.First().Name;	 
		pkName = pkName.Substring(0, 1).ToLower() + pkName.Substring(1, pkName.Length - 1); 
	}

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 30 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.NameSpace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic class ");
            
            #line 32 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            
            #line 32 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassNameExtend));
            
            #line default
            #line hidden
            this.Write(" : BaseController\r\n    {\r\n        [Dependency]\r\n        public I");
            
            #line 35 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Service ");
            
            #line 35 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Service { get; set; }\r\n\r\n        public ActionResult Index(int? page)\r\n        {\r" +
                    "\n            var p = page ?? 1;\r\n            var total = 0;\r\n            var mod" +
                    "els = this.");
            
            #line 41 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Service.GetModels(p, 5, string.Empty, \"");
            
            #line 41 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write("\", null, out total);\r\n            var dtos = Mapper.Map<List<");
            
            #line 42 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("DTO>>(models);\r\n           \r\n            if (dtos == null)\r\n                dtos " +
                    "= new List<");
            
            #line 45 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("DTO>();   \r\n\t\t   \r\n            var pm = this.Kernel.CreatePageModel(5, p, total);" +
                    "\r\n\r\n            this.ViewBag.PM = pm;\r\n\r\n            return this.View(dtos);\r\n  " +
                    "      }\r\n\r\n        public ActionResult Details(");
            
            #line 54 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 54 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            var entity = this.");
            
            #line 56 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Service.GetModel(");
            
            #line 56 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(");\r\n            var model = Mapper.Map<");
            
            #line 57 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("DTO>(entity);\r\n\r\n            return this.View(model);\r\n        }\r\n\r\n        publi" +
                    "c ActionResult Create()\r\n        {\r\n            return this.View();\r\n        }\r\n" +
                    "\r\n        [HttpPost]\r\n        public ActionResult Create(");
            
            #line 68 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("DTO model)\r\n        {\r\n            try\r\n            {\r\n                var entity" +
                    " = Mapper.Map<");
            
            #line 72 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(">(model);\r\n\r\n                this.");
            
            #line 74 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Service.Add(entity);\r\n\r\n                return this.RedirectToAction(\"Index\");\r\n " +
                    "           }\r\n            catch\r\n            {\r\n                return this.View" +
                    "();\r\n            }\r\n        }\r\n\r\n        public ActionResult Edit(");
            
            #line 84 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 84 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            var entity = this.");
            
            #line 86 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Service.GetModel(");
            
            #line 86 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(");\r\n            var model = Mapper.Map<");
            
            #line 87 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("DTO>(entity);\r\n\r\n            return this.View(model);\r\n        }\r\n\r\n        [Http" +
                    "Post]\r\n        public ActionResult Edit(");
            
            #line 93 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("DTO model)\r\n        {\r\n            try\r\n            {\r\n                var entity" +
                    " = Mapper.Map<");
            
            #line 97 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(">(model);\r\n\r\n                this.");
            
            #line 99 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Service.Modify(entity);\r\n\r\n                return this.RedirectToAction(\"Index\");" +
                    "\r\n            }\r\n            catch\r\n            {\r\n                return this.V" +
                    "iew();\r\n            }\r\n        }\r\n\r\n        public ActionResult Delete(");
            
            #line 109 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 109 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            this.");
            
            #line 111 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Service.Delete(");
            
            #line 111 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n            return this.RedirectToAction(\"Index\");\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "D:\Work\Code\Oct.Framework\Oct.Tools\Oct.Tools.Host\Res\Temp\Controller.tt"

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
    public class ControllerBase
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
