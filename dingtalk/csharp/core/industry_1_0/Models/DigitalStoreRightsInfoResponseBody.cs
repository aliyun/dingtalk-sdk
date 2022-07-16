// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreRightsInfoResponseBody : TeaModel {
        /// <summary>
        /// 权益过期时间
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 门店通通讯录根节点Id
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// 门店通通讯录名称
        /// </summary>
        [NameInMap("rightsCode")]
        [Validation(Required=false)]
        public string RightsCode { get; set; }

        /// <summary>
        /// 门店通通讯录Code
        /// </summary>
        [NameInMap("rightsName")]
        [Validation(Required=false)]
        public string RightsName { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
