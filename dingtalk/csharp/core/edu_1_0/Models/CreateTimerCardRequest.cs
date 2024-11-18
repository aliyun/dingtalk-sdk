// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateTimerCardRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("actionTime")]
        [Validation(Required=false)]
        public long? ActionTime { get; set; }

        [NameInMap("bizData")]
        [Validation(Required=false)]
        public string BizData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CARD_EVENT</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding13424</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20241213123213</para>
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

        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

    }

}
