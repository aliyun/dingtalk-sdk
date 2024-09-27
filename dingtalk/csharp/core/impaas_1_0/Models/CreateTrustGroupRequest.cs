// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class CreateTrustGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel_abcd</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@lALOKACADDA</para>
        /// </summary>
        [NameInMap("iconMediaId")]
        [Validation(Required=false)]
        public string IconMediaId { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<CreateTrustGroupRequestMembers> Members { get; set; }
        public class CreateTrustGroupRequestMembers : TeaModel {
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试群名称XXX</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>你有新的会话</para>
        /// </summary>
        [NameInMap("systemMsg")]
        [Validation(Required=false)]
        public string SystemMsg { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657099913071</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
