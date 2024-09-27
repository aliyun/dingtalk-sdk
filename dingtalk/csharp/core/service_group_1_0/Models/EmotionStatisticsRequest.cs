// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class EmotionStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220101</para>
        /// </summary>
        [NameInMap("maxDt")]
        [Validation(Required=false)]
        public string MaxDt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("maxEmotion")]
        [Validation(Required=false)]
        public double? MaxEmotion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220101</para>
        /// </summary>
        [NameInMap("minDt")]
        [Validation(Required=false)]
        public string MinDt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("minEmotion")]
        [Validation(Required=false)]
        public double? MinEmotion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidXX,cidYY</para>
        /// </summary>
        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public string OpenConversationIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ksdfosd</para>
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KxisoOk</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
