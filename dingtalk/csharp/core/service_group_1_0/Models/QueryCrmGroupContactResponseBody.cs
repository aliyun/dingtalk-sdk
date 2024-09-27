// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryCrmGroupContactResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>token****</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cid****</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<QueryCrmGroupContactResponseBodyRecords> Records { get; set; }
        public class QueryCrmGroupContactResponseBodyRecords : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{} ,具体字段取决于客户管理-字段管理-联系人字段设置</para>
            /// </summary>
            [NameInMap("contactData")]
            [Validation(Required=false)]
            public string ContactData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ahghgg</para>
            /// </summary>
            [NameInMap("memberUnionId")]
            [Validation(Required=false)]
            public string MemberUnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>88888</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
