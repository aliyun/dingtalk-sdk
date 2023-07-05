// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListStarsRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public ListStarsRequestOption Option { get; set; }
        public class ListStarsRequestOption : TeaModel {
            [NameInMap("contentTypeList")]
            [Validation(Required=false)]
            public List<string> ContentTypeList { get; set; }

            [NameInMap("filterDocTypes")]
            [Validation(Required=false)]
            public List<string> FilterDocTypes { get; set; }

            [NameInMap("listV2")]
            [Validation(Required=false)]
            public bool? ListV2 { get; set; }

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            [NameInMap("orderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

            [NameInMap("withDentryCreatorInfo")]
            [Validation(Required=false)]
            public bool? WithDentryCreatorInfo { get; set; }

            [NameInMap("withDentryModifierInfo")]
            [Validation(Required=false)]
            public bool? WithDentryModifierInfo { get; set; }

            [NameInMap("withDentryPermissionRole")]
            [Validation(Required=false)]
            public bool? WithDentryPermissionRole { get; set; }

            [NameInMap("withSpaceDetail")]
            [Validation(Required=false)]
            public bool? WithSpaceDetail { get; set; }

            [NameInMap("withSpacePermissionRole")]
            [Validation(Required=false)]
            public bool? WithSpacePermissionRole { get; set; }

            [NameInMap("withTeamDetail")]
            [Validation(Required=false)]
            public bool? WithTeamDetail { get; set; }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
