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

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("listV2")]
            [Validation(Required=false)]
            public bool? ListV2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>next_token</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASC</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>createTime</para>
            /// </summary>
            [NameInMap("orderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("withDentryCreatorInfo")]
            [Validation(Required=false)]
            public bool? WithDentryCreatorInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("withDentryModifierInfo")]
            [Validation(Required=false)]
            public bool? WithDentryModifierInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("withDentryPermissionRole")]
            [Validation(Required=false)]
            public bool? WithDentryPermissionRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("withSpaceDetail")]
            [Validation(Required=false)]
            public bool? WithSpaceDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("withSpacePermissionRole")]
            [Validation(Required=false)]
            public bool? WithSpacePermissionRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("withTeamDetail")]
            [Validation(Required=false)]
            public bool? WithTeamDetail { get; set; }

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
