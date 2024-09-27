// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SyncDataRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("triggerDataList")]
        [Validation(Required=false)]
        public List<SyncDataRequestTriggerDataList> TriggerDataList { get; set; }
        public class SyncDataRequestTriggerDataList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("customTriggerId")]
            [Validation(Required=false)]
            public string CustomTriggerId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dataGmtCreate")]
            [Validation(Required=false)]
            public long? DataGmtCreate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dataGmtModified")]
            [Validation(Required=false)]
            public long? DataGmtModified { get; set; }

            /// <summary>
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("integrationObject")]
            [Validation(Required=false)]
            public string IntegrationObject { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("jsonData")]
            [Validation(Required=false)]
            public string JsonData { get; set; }

            [NameInMap("triggerCondition")]
            [Validation(Required=false)]
            public string TriggerCondition { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("triggerId")]
            [Validation(Required=false)]
            public string TriggerId { get; set; }

        }

    }

}
