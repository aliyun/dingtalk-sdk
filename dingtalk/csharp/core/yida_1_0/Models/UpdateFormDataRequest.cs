// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class UpdateFormDataRequest : TeaModel {
        /// <summary>
        /// 应用编码
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// 要更新的表单数据ID
        /// </summary>
        [NameInMap("formInstanceId")]
        [Validation(Required=false)]
        public string FormInstanceId { get; set; }

        /// <summary>
        /// 语言。可选值：zh_CN/en_US 默认：zh_CN
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// 应用秘钥。在应用数据中获取。
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// 要更新的表单组件值。参数有的组件更新，没有的组件保持不变。 明细的值只能统一更新，无法只更新明细下某个组件的值
        /// </summary>
        [NameInMap("updateFormDataJson")]
        [Validation(Required=false)]
        public string UpdateFormDataJson { get; set; }

        /// <summary>
        /// 使用最新的表单版本进行更新。默认为false
        /// </summary>
        [NameInMap("useLatestVersion")]
        [Validation(Required=false)]
        public bool? UseLatestVersion { get; set; }

        /// <summary>
        /// 钉钉userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
