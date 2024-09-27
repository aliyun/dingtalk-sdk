// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeAddStudentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6235234</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”city“:&quot;Beijing&quot;</para>
        /// </summary>
        [NameInMap("empExtension")]
        [Validation(Required=false)]
        public Dictionary<string, string> EmpExtension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>male</para>
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11019xxxxxx0001</para>
        /// </summary>
        [NameInMap("identifyId")]
        [Validation(Required=false)]
        public string IdentifyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186xxxxxxxx</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2015</para>
        /// </summary>
        [NameInMap("startYear")]
        [Validation(Required=false)]
        public string StartYear { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("studentName")]
        [Validation(Required=false)]
        public string StudentName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mf1922051</para>
        /// </summary>
        [NameInMap("studentNumber")]
        [Validation(Required=false)]
        public string StudentNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0324124</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
