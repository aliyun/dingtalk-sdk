// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportEduExpRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportEduExpRequestBody> Body { get; set; }
        public class HrbrainImportEduExpRequestBody : TeaModel {
            [NameInMap("eduName")]
            [Validation(Required=false)]
            public string EduName { get; set; }

            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("major")]
            [Validation(Required=false)]
            public string Major { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("schoolName")]
            [Validation(Required=false)]
            public string SchoolName { get; set; }

            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
