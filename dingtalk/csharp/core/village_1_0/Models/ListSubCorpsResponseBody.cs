// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListSubCorpsResponseBody : TeaModel {
        [NameInMap("corpList")]
        [Validation(Required=false)]
        public List<ListSubCorpsResponseBodyCorpList> CorpList { get; set; }
        public class ListSubCorpsResponseBodyCorpList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("industryCode")]
            [Validation(Required=false)]
            public int? IndustryCode { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("regionLocation")]
            [Validation(Required=false)]
            public string RegionLocation { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("regionType")]
            [Validation(Required=false)]
            public string RegionType { get; set; }

        }

    }

}
