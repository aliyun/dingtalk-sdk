// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AdjustKitRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;&quot;}</para>
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingxxx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ISV_XXX</para>
        /// </summary>
        [NameInMap("isvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>course</para>
        /// </summary>
        [NameInMap("isvProductScene")]
        [Validation(Required=false)]
        public string IsvProductScene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("openEndTime")]
        [Validation(Required=false)]
        public long? OpenEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("openStartTime")]
        [Validation(Required=false)]
        public long? OpenStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>staffxxx</para>
        /// </summary>
        [NameInMap("openUserId")]
        [Validation(Required=false)]
        public string OpenUserId { get; set; }

    }

}
