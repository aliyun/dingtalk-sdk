// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryAllDoctorsResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryAllDoctorsResponseBodyContent> Content { get; set; }
        public class QueryAllDoctorsResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758</para>
            /// </summary>
            [NameInMap("assessGroupId")]
            [Validation(Required=false)]
            public string AssessGroupId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三组</para>
            /// </summary>
            [NameInMap("assessGroupName")]
            [Validation(Required=false)]
            public string AssessGroupName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1312312321</para>
            /// </summary>
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("deptType")]
            [Validation(Required=false)]
            public string DeptType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-08 21:57:10</para>
            /// </summary>
            [NameInMap("gmtCreateStr")]
            [Validation(Required=false)]
            public string GmtCreateStr { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-08 21:57:10</para>
            /// </summary>
            [NameInMap("gmtModifiedStr")]
            [Validation(Required=false)]
            public string GmtModifiedStr { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123345</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0001</para>
            /// </summary>
            [NameInMap("jobNum")]
            [Validation(Required=false)]
            public string JobNum { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u0398812938821</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa12312312</para>
            /// </summary>
            [NameInMap("userCode")]
            [Validation(Required=false)]
            public string UserCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>用户名称</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
