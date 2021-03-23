// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ListUserTeamsResponseBody : TeaModel {
        /// <summary>
        /// teams
        /// </summary>
        [NameInMap("teams")]
        [Validation(Required=false)]
        public List<ListUserTeamsResponseBodyTeams> Teams { get; set; }
        public class ListUserTeamsResponseBodyTeams : TeaModel {
            /// <summary>
            /// 开放团队ID
            /// </summary>
            [NameInMap("openTeamId")]
            [Validation(Required=false)]
            public string OpenTeamId { get; set; }

            /// <summary>
            /// 团队名称
            /// </summary>
            [NameInMap("teamName")]
            [Validation(Required=false)]
            public string TeamName { get; set; }

        }

    }

}
