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
    
    #line 1 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class Service : ServiceBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using Oct.Framework.Entities;\r\nusing System;\r\nusing System.Collections.Generic;\r\n" +
                    "using Oct.Framework.DB.Core;\r\nusing ");
            
            #line 10 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Entities.Entities;\r\n");
            
            #line 11 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"

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
            
            #line 24 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Services\r\n{\r\n\tpublic interface I");
            
            #line 26 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            
            #line 26 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassNameExtend));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        /// <summary>\r\n        /// 新增\r\n        /// </summary>\r\n        /" +
                    "// <param name=\"entity\"></param>\r\n        /// <returns></returns>\r\n        bool " +
                    "Add(");
            
            #line 33 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" entity);\r\n\r\n        /// <summary>\r\n        /// 修改\r\n        /// </summary>\r\n     " +
                    "   /// <param name=\"entity\"></param>\r\n        /// <returns></returns>\r\n        b" +
                    "ool Modify(");
            
            #line 40 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" entity);\r\n\r\n        /// <summary>\r\n        /// 根据一个实体对象删除\r\n        /// </summary" +
                    ">\r\n        /// <param name=\"entity\"></param>\r\n        /// <returns></returns>\r\n " +
                    "       bool Delete(");
            
            #line 47 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" entity);\r\n\r\n        /// <summary>\r\n        /// 根据主键删除\r\n        /// </summary>\r\n " +
                    "       /// <param name=\"");
            
            #line 52 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write("\"></param>\r\n        /// <returns></returns>\r\n        bool Delete(");
            
            #line 54 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 54 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(@");

        /// <summary>
        /// 根据条件删除 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name=""where""></param>
        /// <param name=""paras"">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        bool Delete(string where, IDictionary<string, object> paras);

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name=""");
            
            #line 67 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write("\"></param>\r\n        /// <returns></returns>\r\n        ");
            
            #line 69 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" GetModel(");
            
            #line 69 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 69 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n        /// <summary>\r\n        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值\r\n        /// <" +
                    "/summary>\r\n        /// <param name=\"where\"></param>\r\n        /// <param name=\"pa" +
                    "ras\">参数键为@拼接的参数，值为参数值</param>\r\n        /// <returns></returns>\r\n        List<");
            
            #line 77 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(@"> GetModels(string where = """", IDictionary<string, object> paras = null,string order="""");

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name=""pageIndex""></param>
        /// <param name=""pageSize""></param>
        /// <param name=""where""></param>
        /// <param name=""order""></param>
        /// <param name=""paras""> 参数键为@拼接的参数，值为参数值</param>
        /// <param name=""total""></param>
        /// <returns></returns>
        PageResult<");
            
            #line 89 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("> GetModels(int pageIndex, int pageSize, string where, string order, IDictionary<" +
                    "string, object> paras);\r\n    }\r\n\r\n    public partial class ");
            
            #line 92 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            
            #line 92 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassNameExtend));
            
            #line default
            #line hidden
            this.Write(" : I");
            
            #line 92 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            
            #line 92 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassNameExtend));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        /// <summary>\r\n        /// 新增\r\n        /// </summary>\r\n        /" +
                    "// <param name=\"entity\"></param>\r\n        /// <returns></returns>\r\n        publi" +
                    "c bool Add(");
            
            #line 99 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" entity)\r\n        {\r\n            using (var context = new DbContext())\r\n         " +
                    "   {\r\n\t\tcontext.");
            
            #line 103 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(@"Context.Add(entity);
                
		return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name=""entity""></param>
        /// <returns></returns>
        public bool Modify(");
            
            #line 114 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" entity)\r\n        {\r\n            using (var context = new DbContext())\r\n         " +
                    "   {\r\n\t\tcontext.");
            
            #line 118 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(@"Context.Update(entity);
                
		return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name=""entity""></param>
        /// <returns></returns>
        public bool Delete(");
            
            #line 129 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" entity)\r\n        {\r\n            using (var context = new DbContext())\r\n         " +
                    "   {\r\n\t\tcontext.");
            
            #line 133 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Context.Delete(entity);\r\n                \r\n\t\treturn context.SaveChanges() > 0;\r\n " +
                    "           }\r\n        }\r\n\r\n        /// <summary>\r\n        /// 根据主键删除\r\n        //" +
                    "/ </summary>\r\n        /// <param name=\"");
            
            #line 142 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write("\"></param>\r\n        /// <returns></returns>\r\n        public bool Delete(");
            
            #line 144 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 144 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            using (var context = new DbContext())\r\n            {\r\n\t" +
                    "\tcontext.");
            
            #line 148 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Context.Delete(");
            
            #line 148 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(@");
                
		return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据条件删除 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name=""where""></param>
        /// <param name=""paras"">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        public bool Delete(string @where, IDictionary<string, object> paras)
        {
            using (var context = new DbContext())
            {
		context.");
            
            #line 164 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Context.Delete(@where, paras);\r\n                \r\n\t\treturn context.SaveChanges() " +
                    "> 0;\r\n            }\r\n        }\r\n\r\n        /// <summary>\r\n        /// 通过主键获取一个对象\r" +
                    "\n        /// </summary>\r\n        /// <param name=\"");
            
            #line 173 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write("\"></param>\r\n        /// <returns></returns>\r\n        public ");
            
            #line 175 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" GetModel(");
            
            #line 175 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 175 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            using (var context = new DbContext())\r\n            {\r\n " +
                    "               return context.");
            
            #line 179 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Context.GetModel(");
            
            #line 179 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pkName));
            
            #line default
            #line hidden
            this.Write(@");
            }
        }

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name=""where""></param>
        /// <param name=""paras"">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        public List<");
            
            #line 189 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("> GetModels(string where = \"\", IDictionary<string, object> paras = null,string or" +
                    "der=\"\")\r\n        {\r\n            using (var context = new DbContext())\r\n         " +
                    "   {\r\n                return context.");
            
            #line 193 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(@"Context.Query(@where, paras);
            }
        }

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name=""pageIndex""></param>
        /// <param name=""pageSize""></param>
        /// <param name=""where""></param>
        /// <param name=""order""></param>
        /// <param name=""paras""> 参数键为@拼接的参数，值为参数值</param>
        /// <param name=""total""></param>
        /// <returns></returns>
        public PageResult<");
            
            #line 207 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("> GetModels(int pageIndex, int pageSize, string @where, string order, IDictionary" +
                    "<string, object> paras)\r\n        {\r\n            using (var context = new DbConte" +
                    "xt())\r\n            {\r\n                return context.");
            
            #line 211 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write("Context.QueryPage(where, paras, order, pageIndex, pageSize);\r\n            }\r\n    " +
                    "    }\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\Service.tt"

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
    public class ServiceBase
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
