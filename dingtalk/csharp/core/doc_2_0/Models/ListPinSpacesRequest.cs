// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListPinSpacesRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public ListPinSpacesRequestOption Option { get; set; }
        public class ListPinSpacesRequestOption : TeaModel {
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("withSpaceCreatorInfo")]
            [Validation(Required=false)]
            public bool? WithSpaceCreatorInfo { get; set; }

            [NameInMap("withSpaceModifierInfo")]
            [Validation(Required=false)]
            public bool? WithSpaceModifierInfo { get; set; }

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
