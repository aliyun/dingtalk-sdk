// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserExtInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryUserExtInfoResponseBodyContent> Content { get; set; }
        public class QueryUserExtInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-22 15:30:31</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-22 15:30:31</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

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
            /// <para>10320266246</para>
            /// </summary>
            [NameInMap("userCode")]
            [Validation(Required=false)]
            public string UserCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>扩展属性描述</para>
            /// </summary>
            [NameInMap("userExtendDisplayName")]
            [Validation(Required=false)]
            public string UserExtendDisplayName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>扩展属性Key</para>
            /// </summary>
            [NameInMap("userExtendKey")]
            [Validation(Required=false)]
            public string UserExtendKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>扩展属性值</para>
            /// </summary>
            [NameInMap("userExtendValue")]
            [Validation(Required=false)]
            public string UserExtendValue { get; set; }

        }

    }

}
