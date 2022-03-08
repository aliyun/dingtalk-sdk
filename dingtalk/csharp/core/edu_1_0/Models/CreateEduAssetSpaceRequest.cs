// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateEduAssetSpaceRequest : TeaModel {
        /// <summary>
        /// 业务类型编码
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 空间描述
        /// </summary>
        [NameInMap("spaceDesc")]
        [Validation(Required=false)]
        public string SpaceDesc { get; set; }

        /// <summary>
        /// 空间图标
        /// </summary>
        [NameInMap("spaceIcon")]
        [Validation(Required=false)]
        public string SpaceIcon { get; set; }

        /// <summary>
        /// 空间名称
        /// </summary>
        [NameInMap("spaceName")]
        [Validation(Required=false)]
        public string SpaceName { get; set; }

        /// <summary>
        /// 用户staffId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
