// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetOfficialAccountContactsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10010</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<GetOfficialAccountContactsResponseBodyValues> Values { get; set; }
        public class GetOfficialAccountContactsResponseBodyValues : TeaModel {
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<GetOfficialAccountContactsResponseBodyValuesContacts> Contacts { get; set; }
            public class GetOfficialAccountContactsResponseBodyValuesContacts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-12-25 15:33:12</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("creatorNick")]
                [Validation(Required=false)]
                public string CreatorNick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ding_userid</para>
                /// </summary>
                [NameInMap("creatorUserId")]
                [Validation(Required=false)]
                public string CreatorUserId { get; set; }

                [NameInMap("data")]
                [Validation(Required=false)]
                public Dictionary<string, object> Data { get; set; }

                [NameInMap("extendData")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtendData { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>instance_id</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-12-25 15:33:12</para>
                /// </summary>
                [NameInMap("modifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("permission")]
                [Validation(Required=false)]
                public GetOfficialAccountContactsResponseBodyValuesContactsPermission Permission { get; set; }
                public class GetOfficialAccountContactsResponseBodyValuesContactsPermission : TeaModel {
                    [NameInMap("ownerStaffIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerStaffIds { get; set; }

                    [NameInMap("participantStaffIds")]
                    [Validation(Required=false)]
                    public List<string> ParticipantStaffIds { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user_id</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
