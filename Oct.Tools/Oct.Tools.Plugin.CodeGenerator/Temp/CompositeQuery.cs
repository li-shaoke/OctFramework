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
    
    #line 1 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class CompositeQuery : CompositeQueryBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using Oct.Framework.DB.Base;\r\nusing Oct.Framework.DB.Core;\r\nusing Oct.Framework.D" +
                    "B.Interface;\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Dat" +
                    "a;\r\nusing System.Data.Common;\r\nusing System.Data.SqlClient;\r\nusing System.Text;\r" +
                    "\n\r\nnamespace ");
            
            #line 16 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.NameSpace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t[Serializable]\r\n\tpublic partial class ");
            
            #line 19 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            
            #line 19 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassNameExtend));
            
            #line default
            #line hidden
            this.Write(" : BaseEntity<");
            
            #line 19 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            
            #line 19 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassNameExtend));
            
            #line default
            #line hidden
            this.Write(">\r\n\t{ \r\n\t\t#region\t属性\r\n\t\t");
            
            #line 22 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"

			foreach(FiledInfo filed in dt.FiledList) 
			{		
		
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 27 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.CSharpType + " " + filed.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t{\r\n\t\t\tget;\r\n\t\t\tset;\r\n\t\t}\r\n\t\t");
            
            #line 32 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t#endregion\r\n\r\n\t\t#region 重载\r\n\r\n\t\tpublic override ");
            
            #line 38 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" GetEntityFromDataRow(DataRow row)\r\n\t\t{\r\n\t\t\t");
            
            #line 40 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
		
				var code = new StringBuilder();

				for (int i = 0; i < dt.FiledList.Count; i++)
				{
					var filed = dt.FiledList[i];
					var type = filed.CSharpType.ToLower();
					if (type == "bool")
					{
						code.AppendFormat("{0}if (row.Table.Columns.Contains(\"{1}\") && row[\"{1}\"] != null && row[\"{1}\"].ToString() != \"\")\r\n", i == 0 ? string.Empty : "\t\t\t", filed.Name);	
						code.Append("\t\t\t{\r\n");
						code.AppendFormat("\t\t\t\tif ((row[\"{0}\"].ToString() == \"1\") || (row[\"{0}\"].ToString().ToLower() == \"true\"))\r\n", filed.Name);
						code.Append("\t\t\t\t{\r\n");
						code.AppendFormat("\t\t\t\t\tthis.{0} = true;\r\n", filed.Name);
						code.Append("\t\t\t\t}\r\n");
						code.Append("\t\t\t\telse\r\n");
						code.Append("\t\t\t\t{\r\n");
						code.AppendFormat("\t\t\t\t\tthis.{0} = false;\r\n",filed.Name);
						code.Append("\t\t\t\t}\r\n");	
						code.Append("\t\t\t}\r\n");	
					}
					else if (type == "byte[]")
					{
						code.AppendFormat("{0}if (row.Table.Columns.Contains(\"{1}\") && row[\"{1}\"] != null && row[\"{1}\"].ToString() != \"\")\r\n", i == 0 ? string.Empty : "\t\t\t", filed.Name);	
						code.Append("\t\t\t{\r\n");
						code.AppendFormat("\t\t\t\tthis.{0} = (byte[])row[\"{1}\"];\r\n", filed.Name,filed.Name);	
						code.Append("\t\t\t}\r\n");	
					}
					else if (type == "datetime")
					{
						code.AppendFormat("{0}if (row.Table.Columns.Contains(\"{1}\") && row[\"{1}\"] != null && row[\"{1}\"].ToString() != \"\")\r\n", i == 0 ? string.Empty : "\t\t\t", filed.Name);	
						code.Append("\t\t\t{\r\n");
						code.AppendFormat("\t\t\t\tthis.{0} = DateTime.Parse(row[\"{1}\"].ToString());\r\n",  filed.Name,filed.Name);	
						code.Append("\t\t\t}\r\n");	
					}
					else if (type == "guid")
					{
						code.AppendFormat("{0}if (row.Table.Columns.Contains(\"{1}\") && row[\"{1}\"] != null && row[\"{1}\"].ToString() != \"\")\r\n", i == 0 ? string.Empty : "\t\t\t", filed.Name);	
						code.Append("\t\t\t{\r\n");
						code.AppendFormat("\t\t\t\tthis.{0} = new Guid(row[\"{1}\"].ToString());\r\n",  filed.Name,filed.Name);	
						code.Append("\t\t\t}\r\n");	
					}
					else if (type == "string")
					{
						code.AppendFormat("{0}if (row.Table.Columns.Contains(\"{1}\") && row[\"{1}\"] != null)\r\n", i == 0 ? string.Empty : "\t\t\t", filed.Name);	
						code.Append("\t\t\t{\r\n");
						code.AppendFormat("\t\t\t\tthis.{0} = row[\"{1}\"].ToString();\r\n",  filed.Name,filed.Name);	
						code.Append("\t\t\t}\r\n");	
					}
					else if (type == "decimal" || type == "double" || type == "float" || type == "int" || type == "long")
					{
						code.AppendFormat("{0}if (row.Table.Columns.Contains(\"{1}\") && row[\"{1}\"] != null && row[\"{1}\"].ToString() != \"\")\r\n", i == 0 ? string.Empty : "\t\t\t", filed.Name);	
						code.Append("\t\t\t{\r\n");
						code.AppendFormat("\t\t\t\tthis.{0} = {1}.Parse(row[\"{2}\"].ToString());\r\n", filed.Name, type,filed.Name);	
						code.Append("\t\t\t}\r\n");	
					}
				}
			
            
            #line default
            #line hidden
            
            #line 98 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(code.ToString()));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\treturn this;\r\n\t\t}\r\n\r\n\t\tpublic override ");
            
            #line 102 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(" GetEntityFromDataReader(IDataReader reader)\r\n        {\r\n            for (int i =" +
                    " 0; i < reader.FieldCount; i++)\r\n            {\r\n                var name = reade" +
                    "r.GetName(i);\r\n\t\t\t\t");
            
            #line 107 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"

				for (int i = 0; i < dt.FiledList.Count; i++)
				{
					var filed = dt.FiledList[i];
					var type = filed.CSharpType.ToLower();	
					
            
            #line default
            #line hidden
            this.Write("if (name.ToLower() == \"");
            
            #line 113 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name.ToLower()));
            
            #line default
            #line hidden
            this.Write("\"  && !reader.IsDBNull(i))\r\n{\r\n");
            
            #line 115 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
if(type == "bool")
{
            
            #line default
            #line hidden
            
            #line 117 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = reader.GetBoolean(i);\r\n");
            
            #line 118 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            
            #line 119 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
if(type == "byte[]")
{
            
            #line default
            #line hidden
            
            #line 121 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = (byte[])reader.GetValue(i);\r\n");
            
            #line 122 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            
            #line 123 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
if(type == "datetime")
{
            
            #line default
            #line hidden
            
            #line 125 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = reader.GetDateTime(i);\r\n");
            
            #line 126 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            
            #line 127 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
if(type == "guid")
{
            
            #line default
            #line hidden
            
            #line 129 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = reader.GetGuid(i);\r\n");
            
            #line 130 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            
            #line 131 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
if(type == "string")
{
            
            #line default
            #line hidden
            
            #line 133 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = reader.GetString(i);\r\n");
            
            #line 134 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            
            #line 135 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
if(type == "decimal")
{
            
            #line default
            #line hidden
            
            #line 137 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = reader.GetDecimal(i);\r\n");
            
            #line 138 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            
            #line 139 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
if(type == "double")
{
            
            #line default
            #line hidden
            
            #line 141 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = reader.GetDouble(i);\r\n");
            
            #line 142 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            
            #line 143 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
if(type == "float")
{
            
            #line default
            #line hidden
            
            #line 145 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = reader.GetFloat(i);\r\n");
            
            #line 146 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            
            #line 147 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
if(type == "int")
{
            
            #line default
            #line hidden
            
            #line 149 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = reader.GetInt32(i);\r\n");
            
            #line 150 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            
            #line 151 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
if(type == "long")
{
            
            #line default
            #line hidden
            
            #line 153 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write(" = reader.GetInt64(i);\r\n");
            
            #line 154 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            this.Write(" continue;\r\n }\r\n");
            
            #line 157 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            this.Write("               \r\n}\r\n            return this;\r\n        }\r\n\r\n\t\tpublic override stri" +
                    "ng TableName\r\n\t\t{\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\treturn \"");
            
            #line 166 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.ClassName));
            
            #line default
            #line hidden
            this.Write(@""";
			}
		}

		 public override bool IsIdentityPk
        {
            get { return false; }
        }

        private Dictionary<string, string> _props;

		public override Dictionary<string, string> Props
	    {
	        get {
				if(_props == null)
				{
					_props = new Dictionary<string, string>();
					");
            
            #line 183 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
for (int i = 0; i < dt.FiledList.Count; i++){
					var filed = dt.FiledList[i];
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t_props.Add( \"");
            
            #line 185 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write("\",\"");
            
            #line 185 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filed.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t\t\t\t");
            
            #line 186 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t\t}\r\n\t\t\t\treturn _props;\t\t\t \r\n\t\t\t }\r\n\t    }\r\n\r\n\t\tpublic override string GetQuery" +
                    "SQL(string @where = \"\")\r\n\t\t{\r\n\t\t\tvar sql = @\"");
            
            #line 194 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dt.Sql));
            
            #line default
            #line hidden
            this.Write(" where 1=1 \";\r\n           \r\n\t\t\tif (!string.IsNullOrEmpty(@where))\r\n\t\t\t\tsql += \"an" +
                    "d \" + @where;\r\n\r\n\t\t\treturn sql;\r\n\t\t}\r\n\r\n\t\t#endregion\r\n\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "D:\project\Oct.Frame\Oct.Tools\Oct.Tools.Plugin.CodeGenerator\Temp\CompositeQuery.tt"

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
    public class CompositeQueryBase
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
