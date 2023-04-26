// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CreateSpaceRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("sectionId")]
        [Validation(Required=false)]
        public string SectionId { get; set; }

        [NameInMap("shareScope")]
        [Validation(Required=false)]
        public CreateSpaceRequestShareScope ShareScope { get; set; }
        public class CreateSpaceRequestShareScope : TeaModel {
            [NameInMap("scope")]
            [Validation(Required=false)]
            public int? Scope { get; set; }

        }

        [NameInMap("teamId")]
        [Validation(Required=false)]
        public string TeamId { get; set; }

    }

}
