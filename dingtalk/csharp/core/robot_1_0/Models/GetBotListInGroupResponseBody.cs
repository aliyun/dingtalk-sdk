// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class GetBotListInGroupResponseBody : TeaModel {
        [NameInMap("chatbotInstanceVOList")]
        [Validation(Required=false)]
        public List<GetBotListInGroupResponseBodyChatbotInstanceVOList> ChatbotInstanceVOList { get; set; }
        public class GetBotListInGroupResponseBodyChatbotInstanceVOList : TeaModel {
            [NameInMap("downloadIconURL")]
            [Validation(Required=false)]
            public string DownloadIconURL { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("openRobotType")]
            [Validation(Required=false)]
            public int? OpenRobotType { get; set; }

            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

        }

    }

}
