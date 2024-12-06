// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class ListAllTaskViewResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListAllTaskViewResponseBodyResult Result { get; set; }
        public class ListAllTaskViewResponseBodyResult : TeaModel {
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
            public ListAllTaskViewResponseBodyResultGroupType GroupType { get; set; }
            public class ListAllTaskViewResponseBodyResultGroupType : TeaModel {
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
            public ListAllTaskViewResponseBodyResultOrderType OrderType { get; set; }
            public class ListAllTaskViewResponseBodyResultOrderType : TeaModel {
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
            public ListAllTaskViewResponseBodyResultShowType ShowType { get; set; }
            public class ListAllTaskViewResponseBodyResultShowType : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("toolbarInfo")]
            [Validation(Required=false)]
            public ListAllTaskViewResponseBodyResultToolbarInfo ToolbarInfo { get; set; }
            public class ListAllTaskViewResponseBodyResultToolbarInfo : TeaModel {
                [NameInMap("groupTypes")]
                [Validation(Required=false)]
                public List<ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes> GroupTypes { get; set; }
                public class ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes : TeaModel {
                    [NameInMap("canCreateGroup")]
                    [Validation(Required=false)]
                    public bool? CanCreateGroup { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("serviceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                    [NameInMap("setting")]
                    [Validation(Required=false)]
                    public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting Setting { get; set; }
                    public class ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting : TeaModel {
                        [NameInMap("dateType")]
                        [Validation(Required=false)]
                        public string DateType { get; set; }

                        [NameInMap("fieldName")]
                        [Validation(Required=false)]
                        public string FieldName { get; set; }

                        [NameInMap("fieldType")]
                        [Validation(Required=false)]
                        public string FieldType { get; set; }

                    }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("orderTypes")]
                [Validation(Required=false)]
                public List<ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes> OrderTypes { get; set; }
                public class ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes : TeaModel {
                    [NameInMap("direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("supportDirection")]
                    [Validation(Required=false)]
                    public string SupportDirection { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("showTypes")]
                [Validation(Required=false)]
                public List<ListAllTaskViewResponseBodyResultToolbarInfoShowTypes> ShowTypes { get; set; }
                public class ListAllTaskViewResponseBodyResultToolbarInfoShowTypes : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

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
            public ListAllTaskViewResponseBodyResultViewSetting ViewSetting { get; set; }
            public class ListAllTaskViewResponseBodyResultViewSetting : TeaModel {
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
