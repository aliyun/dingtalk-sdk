// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryDigitalDistrictOrgInfoRequest : TeaModel {
        [NameInMap("kpiGroupId")]
        [Validation(Required=false)]
        public string KpiGroupId { get; set; }

        [NameInMap("statDates")]
        [Validation(Required=false)]
        public List<string> StatDates { get; set; }

        [NameInMap("orgIds")]
        [Validation(Required=false)]
        public List<string> OrgIds { get; set; }

    }

}
