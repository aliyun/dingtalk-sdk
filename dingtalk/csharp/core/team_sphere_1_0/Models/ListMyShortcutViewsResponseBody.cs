// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class ListMyShortcutViewsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f279e812-e431-428d-846d-cxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListMyShortcutViewsResponseBodyResult> Result { get; set; }
        public class ListMyShortcutViewsResponseBodyResult : TeaModel {
            [NameInMap("boundToObjectId")]
            [Validation(Required=false)]
            public string BoundToObjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("boundToObjectType")]
            [Validation(Required=false)]
            public string BoundToObjectType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5f687406f05b283425ea8f6f</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("groupType")]
            [Validation(Required=false)]
            public ListMyShortcutViewsResponseBodyResultGroupType GroupType { get; set; }
            public class ListMyShortcutViewsResponseBodyResultGroupType : TeaModel {
                [NameInMap("canCreateGroup")]
                [Validation(Required=false)]
                public bool? CanCreateGroup { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>x项目</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("orderType")]
            [Validation(Required=false)]
            public ListMyShortcutViewsResponseBodyResultOrderType OrderType { get; set; }
            public class ListMyShortcutViewsResponseBodyResultOrderType : TeaModel {
                [NameInMap("direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6139cd1aba5b128516ec8c86</para>
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("showType")]
            [Validation(Required=false)]
            public ListMyShortcutViewsResponseBodyResultShowType ShowType { get; set; }
            public class ListMyShortcutViewsResponseBodyResultShowType : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            [NameInMap("viewSetting")]
            [Validation(Required=false)]
            public ListMyShortcutViewsResponseBodyResultViewSetting ViewSetting { get; set; }
            public class ListMyShortcutViewsResponseBodyResultViewSetting : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("showDoneTask")]
                [Validation(Required=false)]
                public bool? ShowDoneTask { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("showSubTask")]
                [Validation(Required=false)]
                public bool? ShowSubTask { get; set; }

            }

        }

    }

}
