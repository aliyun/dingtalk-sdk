// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetSignedDetailByPageResponseBody : TeaModel {
        [NameInMap("auditSignedDetailDTOList")]
        [Validation(Required=false)]
        public List<GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList> AuditSignedDetailDTOList { get; set; }
        public class GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>部门1</para>
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b>@</b>.com</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小张</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>主管理员</para>
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public string Roles { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123***</para>
            /// </summary>
            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>经理</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
