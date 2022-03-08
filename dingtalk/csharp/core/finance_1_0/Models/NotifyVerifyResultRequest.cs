// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class NotifyVerifyResultRequest : TeaModel {
        /// <summary>
        /// 企业ID
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 码值
        /// </summary>
        [NameInMap("payCode")]
        [Validation(Required=false)]
        public string PayCode { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户
        /// </summary>
        [NameInMap("userCorpRelationType")]
        [Validation(Required=false)]
        public string UserCorpRelationType { get; set; }

        /// <summary>
        /// 用户身份标识
        /// </summary>
        [NameInMap("userIdentity")]
        [Validation(Required=false)]
        public string UserIdentity { get; set; }

        /// <summary>
        /// 验证事件，长度不超过8个中文
        /// </summary>
        [NameInMap("verifyEvent")]
        [Validation(Required=false)]
        public string VerifyEvent { get; set; }

        /// <summary>
        /// 验证地点，调用时请务必传入，以便生成工牌使用记录
        /// </summary>
        [NameInMap("verifyLocation")]
        [Validation(Required=false)]
        public string VerifyLocation { get; set; }

        /// <summary>
        /// 验证流水号，长度不超过32位，用户下唯一，调用时请务必传入，以便生成工牌使用记录
        /// </summary>
        [NameInMap("verifyNo")]
        [Validation(Required=false)]
        public string VerifyNo { get; set; }

        /// <summary>
        /// 验证结果
        /// </summary>
        [NameInMap("verifyResult")]
        [Validation(Required=false)]
        public bool? VerifyResult { get; set; }

        /// <summary>
        /// 验证时间
        /// </summary>
        [NameInMap("verifyTime")]
        [Validation(Required=false)]
        public string VerifyTime { get; set; }

    }

}
