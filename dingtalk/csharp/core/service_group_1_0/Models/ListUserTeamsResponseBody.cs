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
            /// <summary>
            /// <b>Example:</b>
            /// <para>Jxi12wo3qxoa</para>
            /// </summary>
            [NameInMap("openTeamId")]
            [Validation(Required=false)]
            public string OpenTeamId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试团队</para>
            /// </summary>
            [NameInMap("teamName")]
            [Validation(Required=false)]
            public string TeamName { get; set; }

        }

    }

}
