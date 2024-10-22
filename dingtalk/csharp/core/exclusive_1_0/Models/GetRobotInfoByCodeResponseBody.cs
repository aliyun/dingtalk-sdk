// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetRobotInfoByCodeResponseBody : TeaModel {
        [NameInMap("robotInfoVO")]
        [Validation(Required=false)]
        public GetRobotInfoByCodeResponseBodyRobotInfoVO RobotInfoVO { get; set; }
        public class GetRobotInfoByCodeResponseBodyRobotInfoVO : TeaModel {
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            [NameInMap("brief")]
            [Validation(Required=false)]
            public string Brief { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("robotOrganization")]
            [Validation(Required=false)]
            public long? RobotOrganization { get; set; }

        }

    }

}
