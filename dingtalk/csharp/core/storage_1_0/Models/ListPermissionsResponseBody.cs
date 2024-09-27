// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>next_token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class ListPermissionsResponseBodyPermissions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dentry_id</para>
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("member")]
            [Validation(Required=false)]
            public ListPermissionsResponseBodyPermissionsMember Member { get; set; }
            public class ListPermissionsResponseBodyPermissionsMember : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>corp_id</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>member_id</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>operator_id</para>
            /// </summary>
            [NameInMap("operatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public ListPermissionsResponseBodyPermissionsRole Role { get; set; }
            public class ListPermissionsResponseBodyPermissionsRole : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>MANAGER</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MANAGER</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>space_id</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

    }

}
