// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class UpdateStorageModeRequest : TeaModel {
        /// <summary>
        /// 专属文件跨云存储类型 0：公有模式，1：私有模式，注意，如不更新，则不填写这个字段，字段一旦有值，都会触发原有配置的删除
        /// </summary>
        [NameInMap("fileStorageMode")]
        [Validation(Required=false)]
        public string FileStorageMode { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

    }

}
