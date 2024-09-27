// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OpenKeyResultDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>65222713d0e8b868f9f9ae51</para>
        /// </summary>
        [NameInMap("krId")]
        [Validation(Required=false)]
        public string KrId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是一个KR</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("titleMentions")]
        [Validation(Required=false)]
        public List<TitleMention> TitleMentions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.00</para>
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public double? Weight { get; set; }

    }

}
