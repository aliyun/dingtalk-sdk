// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class AddTeamResponseBody : TeaModel {
        [NameInMap("team")]
        [Validation(Required=false)]
        public AddTeamResponseBodyTeam Team { get; set; }
        public class AddTeamResponseBodyTeam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>corp_id</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_cover</para>
            /// </summary>
            [NameInMap("cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_create_time</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_creator_id</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public AddTeamResponseBodyTeamIcon Icon { get; set; }
            public class AddTeamResponseBodyTeamIcon : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>URL</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>icon_url</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_modified_time</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_modifier_id</para>
            /// </summary>
            [NameInMap("modifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_id</para>
            /// </summary>
            [NameInMap("teamId")]
            [Validation(Required=false)]
            public string TeamId { get; set; }

        }

    }

}
