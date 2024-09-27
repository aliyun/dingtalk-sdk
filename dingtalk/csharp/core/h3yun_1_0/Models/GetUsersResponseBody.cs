// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetUsersResponseBodyData> Data { get; set; }
        public class GetUsersResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18f923a7-5a5e-426d-94ae-a55ad1a4b240</para>
            /// </summary>
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>研发中心</para>
            /// </summary>
            [NameInMap("departmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Null</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Internal</para>
            /// </summary>
            [NameInMap("domainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:zhangsan@example.com">zhangsan@example.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>018bbb56-a9dd-49a1-8495-129c6b0d95c5</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>156********</para>
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("partDepartmentIds")]
            [Validation(Required=false)]
            public List<string> PartDepartmentIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Man</para>
            /// </summary>
            [NameInMap("sex")]
            [Validation(Required=false)]
            public string Sex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>176294501822126512</para>
            /// </summary>
            [NameInMap("sortKey")]
            [Validation(Required=false)]
            public long? SortKey { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
