// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportPunDetailRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportPunDetailRequestBody> Body { get; set; }
        public class HrbrainImportPunDetailRequestBody : TeaModel {
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("effectiveDate")]
            [Validation(Required=false)]
            public string EffectiveDate { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("punName")]
            [Validation(Required=false)]
            public string PunName { get; set; }

            [NameInMap("punOrg")]
            [Validation(Required=false)]
            public string PunOrg { get; set; }

            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
