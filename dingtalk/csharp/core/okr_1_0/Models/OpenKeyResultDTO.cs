/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OpenKeyResultDTO : TeaModel {
        [NameInMap("krId")]
        [Validation(Required=false)]
        public string KrId { get; set; }

        [NameInMap("progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("titleMentions")]
        [Validation(Required=false)]
        public List<TitleMention> TitleMentions { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
