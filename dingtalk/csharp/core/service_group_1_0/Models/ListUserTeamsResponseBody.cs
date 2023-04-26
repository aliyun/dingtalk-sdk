// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ListUserTeamsResponseBody : TeaModel {
        [NameInMap("teams")]
        [Validation(Required=false)]
        public List<ListUserTeamsResponseBodyTeams> Teams { get; set; }
        public class ListUserTeamsResponseBodyTeams : TeaModel {
            [NameInMap("openTeamId")]
            [Validation(Required=false)]
            public string OpenTeamId { get; set; }

            [NameInMap("teamName")]
            [Validation(Required=false)]
            public string TeamName { get; set; }

        }

    }

}
