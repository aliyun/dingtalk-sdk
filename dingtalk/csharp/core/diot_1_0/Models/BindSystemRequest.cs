// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BindSystemRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abcde12345</para>
        /// </summary>
        [NameInMap("authCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d12345</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx社区。</para>
        /// </summary>
        [NameInMap("clientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding12345</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extraData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraData { get; set; }

    }

}
