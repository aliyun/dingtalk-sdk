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

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<GetContactsResponseBodyResultValues> Values { get; set; }
            public class GetContactsResponseBodyResultValues : TeaModel {
                [NameInMap("creatorUserId")]
                [Validation(Required=false)]
                public string CreatorUserId { get; set; }

                [NameInMap("data")]
                [Validation(Required=false)]
                public Dictionary<string, string> Data { get; set; }

                [NameInMap("extendData")]
                [Validation(Required=false)]
                public Dictionary<string, string> ExtendData { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

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
