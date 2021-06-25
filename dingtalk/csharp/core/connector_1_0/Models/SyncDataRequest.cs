// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SyncDataRequest : TeaModel {
        [NameInMap("triggerDataList")]
        [Validation(Required=false)]
        public List<SyncDataRequestTriggerDataList> TriggerDataList { get; set; }
        public class SyncDataRequestTriggerDataList : TeaModel {
            [NameInMap("triggerId")]
            [Validation(Required=false)]
            public string TriggerId { get; set; }

            [NameInMap("customTriggerId")]
            [Validation(Required=false)]
            public string CustomTriggerId { get; set; }

            [NameInMap("jsonData")]
            [Validation(Required=false)]
            public string JsonData { get; set; }

            [NameInMap("dataGmtCreate")]
            [Validation(Required=false)]
            public long? DataGmtCreate { get; set; }

            [NameInMap("dataGmtModified")]
            [Validation(Required=false)]
            public long? DataGmtModified { get; set; }

            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

        }

        /// <summary>
        /// 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
