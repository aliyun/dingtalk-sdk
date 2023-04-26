// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListPunchScheduleByConditionWithPagingRequest : TeaModel {
        [NameInMap("bizInstanceId")]
        [Validation(Required=false)]
        public string BizInstanceId { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("scheduleDateEnd")]
        [Validation(Required=false)]
        public string ScheduleDateEnd { get; set; }

        [NameInMap("scheduleDateStart")]
        [Validation(Required=false)]
        public string ScheduleDateStart { get; set; }

        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
