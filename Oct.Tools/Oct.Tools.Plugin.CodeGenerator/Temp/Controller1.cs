﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 11.0.0.0
//  
//     对此文件的更改可能会导致不正确的行为。此外，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Oct.Tools.Plugin.CodeGenerator.Temp
{
    using System.Linq;
    using System.Text;
    using Oct.Tools.Plugin.CodeGenerator.Entity;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class Controller1 : Controller1Base
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Web.Mvc;\r\nusi" +
                    "ng BoscH.Base;\r\nusing BoscH.DB;\r\n");
            
            #line 11 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"

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
            this.Write("\r\nnamespace BoscH.Controllers\r\n{\r\n\tpublic class ");
            
            #line 26 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            
            #line 26 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassNameExtend));
            
            #line default
            #line hidden
            this.Write(" : BaseController\r\n    {\r\n        public ActionResult Index(int? page)\r\n        {" +
                    "\r\n            var p = page ?? 1;            \r\n           var dtos = Entities.");
            
            #line 31 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("s.Skip((p - 1) * 15).Take(15).ToList();\r\n          \r\n            var pm = this.Cr" +
                    "eatePageModel(5, p, Entities.");
            
            #line 33 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(@"s.Count());

            this.ViewBag.PM = pm;

            return this.View(dtos);
        }     

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(");
            
            #line 46 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" model)\r\n        {\r\n            try\r\n            {\r\n                var entity = " +
                    "Entities.");
            
            #line 50 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("s.Add(model);\r\n\r\n                 Entities.SaveChanges();\r\n                return" +
                    " this.View(\"Jump\");\r\n            }\r\n            catch\r\n            {\r\n          " +
                    "      return this.View();\r\n            }\r\n        }\r\n\r\n        public ActionResu" +
                    "lt Edit(");
            
            #line 61 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 61 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            var entity = Entities.");
            
            #line 63 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("s.FirstOrDefault(p => p.");
            
            #line 63 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkFileds.First().Name));
            
            #line default
            #line hidden
            this.Write(" == ");
            
            #line 63 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n            return this.View(entity);\r\n        }\r\n\r\n        [HttpPost]\r\n   " +
                    "     public ActionResult Edit(");
            
            #line 69 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" model)\r\n        {\r\n            try\r\n            {\r\n\t\t\t    var entity = Entities." +
                    "");
            
            #line 73 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("s.FirstOrDefault(p => p.");
            
            #line 73 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkFileds.First().Name));
            
            #line default
            #line hidden
            this.Write(" == model.");
            
            #line 73 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkFileds.First().Name));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t\tif(entity == null){\r\n\t\t\t\treturn this.View(\"Jump\");\r\n\t\t\t\t}\r\n\t\t\t   ");
            
            #line 77 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
foreach(var filed in dt.FiledList){ 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\tentity.");
            
            #line 78 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = model.");
            
            #line 78 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\t\t");
            
            #line 79 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n                Entities.SaveChanges();\r\n\r\n                return this.View(\"Ju" +
                    "mp\");\r\n            }\r\n            catch\r\n            {\r\n                return t" +
                    "his.View();\r\n            }\r\n        }\r\n\r\n        public ActionResult Delete(");
            
            #line 91 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 91 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n              Entities.");
            
            #line 93 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("s.Remove(new ");
            
            #line 93 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("()\r\n            {\r\n                ");
            
            #line 95 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkFileds.First().Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 95 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write("\r\n            });\r\n            Entities.SaveChanges();\r\n\r\n            return this" +
                    ".RedirectToAction(\"Index\");\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Controller1.tt"

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
    public class Controller1Base
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
