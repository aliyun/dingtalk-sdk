// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportAwardDetailRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportAwardDetailRequestBody> Body { get; set; }
        public class HrbrainImportAwardDetailRequestBody : TeaModel {
            [NameInMap("awardDate")]
            [Validation(Required=false)]
            public string AwardDate { get; set; }

            [NameInMap("awardName")]
            [Validation(Required=false)]
            public string AwardName { get; set; }

            [NameInMap("awardOrg")]
            [Validation(Required=false)]
            public string AwardOrg { get; set; }

            [NameInMap("awardType")]
            [Validation(Required=false)]
            public string AwardType { get; set; }

            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
