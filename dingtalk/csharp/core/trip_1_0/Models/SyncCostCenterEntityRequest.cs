// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncCostCenterEntityRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("channelCorpId")]
        [Validation(Required=false)]
        public string ChannelCorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("costCenterId")]
        [Validation(Required=false)]
        public string CostCenterId { get; set; }

        [NameInMap("delAll")]
        [Validation(Required=false)]
        public bool? DelAll { get; set; }

        [NameInMap("entityList")]
        [Validation(Required=false)]
        public List<SyncCostCenterEntityRequestEntityList> EntityList { get; set; }
        public class SyncCostCenterEntityRequestEntityList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("entityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
