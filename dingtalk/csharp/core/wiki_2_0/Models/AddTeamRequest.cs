// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class AddTeamRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public AddTeamRequestOption Option { get; set; }
        public class AddTeamRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>team_cover</para>
            /// </summary>
            [NameInMap("cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>team_description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public AddTeamRequestOptionIcon Icon { get; set; }
            public class AddTeamRequestOptionIcon : TeaModel {
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

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
