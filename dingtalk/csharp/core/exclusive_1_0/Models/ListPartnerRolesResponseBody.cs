// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListPartnerRolesResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListPartnerRolesResponseBodyList> List { get; set; }
        public class ListPartnerRolesResponseBodyList : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("isNecessary")]
            [Validation(Required=false)]
            public int? IsNecessary { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("visibleDepts")]
            [Validation(Required=false)]
            public List<ListPartnerRolesResponseBodyListVisibleDepts> VisibleDepts { get; set; }
            public class ListPartnerRolesResponseBodyListVisibleDepts : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("visibleUsers")]
            [Validation(Required=false)]
            public List<ListPartnerRolesResponseBodyListVisibleUsers> VisibleUsers { get; set; }
            public class ListPartnerRolesResponseBodyListVisibleUsers : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("warningDepts")]
            [Validation(Required=false)]
            public List<ListPartnerRolesResponseBodyListWarningDepts> WarningDepts { get; set; }
            public class ListPartnerRolesResponseBodyListWarningDepts : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("warningUsers")]
            [Validation(Required=false)]
            public List<ListPartnerRolesResponseBodyListWarningUsers> WarningUsers { get; set; }
            public class ListPartnerRolesResponseBodyListWarningUsers : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
