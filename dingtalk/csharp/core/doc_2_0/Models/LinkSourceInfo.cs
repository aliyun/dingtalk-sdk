// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class LinkSourceInfo : TeaModel {
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        [NameInMap("iconUrl")]
        [Validation(Required=false)]
        public LinkSourceInfoIconUrl IconUrl { get; set; }
        public class LinkSourceInfoIconUrl : TeaModel {
            [NameInMap("line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            [NameInMap("small")]
            [Validation(Required=false)]
            public string Small { get; set; }

        }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("linkType")]
        [Validation(Required=false)]
        public long? LinkType { get; set; }

        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
