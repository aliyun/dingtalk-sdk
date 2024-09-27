// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetContactsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetContactsResponseBodyResult Result { get; set; }
        public class GetContactsResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<GetContactsResponseBodyResultValues> Values { get; set; }
            public class GetContactsResponseBodyResultValues : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>user01</para>
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
                /// <para>2023-11-25 15:33:12</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20123-12-25 15:33:12</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INST_XX</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>crm_contact</para>
                /// </summary>
                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("permission")]
                [Validation(Required=false)]
                public GetContactsResponseBodyResultValuesPermission Permission { get; set; }
                public class GetContactsResponseBodyResultValuesPermission : TeaModel {
                    [NameInMap("ownerUserIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerUserIds { get; set; }

                    [NameInMap("participantUserIds")]
                    [Validation(Required=false)]
                    public List<string> ParticipantUserIds { get; set; }

                }

            }

        }

    }

}
