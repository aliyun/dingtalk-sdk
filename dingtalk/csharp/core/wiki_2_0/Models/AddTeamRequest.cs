// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class AddTeamRequest : TeaModel {
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public AddTeamRequestOption Option { get; set; }
        public class AddTeamRequestOption : TeaModel {
            [NameInMap("cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public AddTeamRequestOptionIcon Icon { get; set; }
            public class AddTeamRequestOptionIcon : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
