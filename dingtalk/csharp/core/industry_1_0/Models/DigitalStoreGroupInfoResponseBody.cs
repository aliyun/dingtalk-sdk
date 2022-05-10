// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreGroupInfoResponseBody : TeaModel {
        /// <summary>
        /// 分组Id
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 分组中门店Id列表
        /// </summary>
        [NameInMap("storeIdList")]
        [Validation(Required=false)]
        public List<long?> StoreIdList { get; set; }

    }

}
