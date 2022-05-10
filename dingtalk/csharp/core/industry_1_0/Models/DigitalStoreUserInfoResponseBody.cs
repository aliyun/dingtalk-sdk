// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreUserInfoResponseBody : TeaModel {
        /// <summary>
        /// 人员名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 管理范围
        /// </summary>
        [NameInMap("scopeList")]
        [Validation(Required=false)]
        public List<long?> ScopeList { get; set; }

        /// <summary>
        /// 所在节点列表
        /// </summary>
        [NameInMap("storeList")]
        [Validation(Required=false)]
        public List<long?> StoreList { get; set; }

        /// <summary>
        /// 人员Id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
