// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenAgoalKeyResultDTO : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("keyActions")]
        [Validation(Required=false)]
        public List<OpenAgoalKeyActionDTO> KeyActions { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("keyResultId")]
        [Validation(Required=false)]
        public string KeyResultId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("titleMentions")]
        [Validation(Required=false)]
        public List<TitleMention> TitleMentions { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public double? Weight { get; set; }

    }

}
