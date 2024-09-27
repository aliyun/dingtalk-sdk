// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryDepartmentExtendInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryDepartmentExtendInfoResponseBodyContent> Content { get; set; }
        public class QueryDepartmentExtendInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231</para>
            /// </summary>
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a</para>
            /// </summary>
            [NameInMap("deptExtendDisplayName")]
            [Validation(Required=false)]
            public string DeptExtendDisplayName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("deptExtendKey")]
            [Validation(Required=false)]
            public string DeptExtendKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("deptExtendValue")]
            [Validation(Required=false)]
            public string DeptExtendValue { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-24 20:30:31</para>
            /// </summary>
            [NameInMap("gmtCreateStr")]
            [Validation(Required=false)]
            public string GmtCreateStr { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-24 20:30:31</para>
            /// </summary>
            [NameInMap("gmtModifiedStr")]
            [Validation(Required=false)]
            public string GmtModifiedStr { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
