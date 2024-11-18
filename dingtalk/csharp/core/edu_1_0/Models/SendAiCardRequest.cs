// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SendAiCardRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>aaa_event</para>
        /// </summary>
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("bizData")]
        [Validation(Required=false)]
        public string BizData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AI_MANAGER_PRINCIPAL</para>
        /// </summary>
        [NameInMap("cardChannel")]
        [Validation(Required=false)]
        public string CardChannel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding23423</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>234234234</para>
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XIWO</para>
        /// </summary>
        [NameInMap("isvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

    }

}
