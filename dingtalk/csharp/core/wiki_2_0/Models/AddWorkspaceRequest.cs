// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class AddWorkspaceRequest : TeaModel {
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public AddWorkspaceRequestOption Option { get; set; }
        public class AddWorkspaceRequestOption : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("teamId")]
            [Validation(Required=false)]
            public string TeamId { get; set; }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
