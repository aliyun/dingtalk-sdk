// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class DeliverCardWithDelegateRequest : TeaModel {
        [NameInMap("coFeedOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestCoFeedOpenDeliverModel CoFeedOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestCoFeedOpenDeliverModel : TeaModel {
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            [NameInMap("gmtTimeLine")]
            [Validation(Required=false)]
            public long? GmtTimeLine { get; set; }

        }

        [NameInMap("docOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestDocOpenDeliverModel DocOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestDocOpenDeliverModel : TeaModel {
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("imGroupOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestImGroupOpenDeliverModel ImGroupOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestImGroupOpenDeliverModel : TeaModel {
            [NameInMap("atUserIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> AtUserIds { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("recipients")]
            [Validation(Required=false)]
            public List<string> Recipients { get; set; }

            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

        }

        [NameInMap("imRobotOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestImRobotOpenDeliverModel ImRobotOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestImRobotOpenDeliverModel : TeaModel {
            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        [NameInMap("openSpaceId")]
        [Validation(Required=false)]
        public string OpenSpaceId { get; set; }

        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("topOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestTopOpenDeliverModel TopOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestTopOpenDeliverModel : TeaModel {
            [NameInMap("expiredTimeMillis")]
            [Validation(Required=false)]
            public long? ExpiredTimeMillis { get; set; }

            [NameInMap("platforms")]
            [Validation(Required=false)]
            public List<string> Platforms { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
