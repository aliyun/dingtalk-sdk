// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ReportCustomerDetailRequest : TeaModel {
        [NameInMap("hasLogin")]
        [Validation(Required=false)]
        public bool? HasLogin { get; set; }

        [NameInMap("hasOpenConv")]
        [Validation(Required=false)]
        public bool? HasOpenConv { get; set; }

        [NameInMap("maxDt")]
        [Validation(Required=false)]
        public string MaxDt { get; set; }

        [NameInMap("minDt")]
        [Validation(Required=false)]
        public string MinDt { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
