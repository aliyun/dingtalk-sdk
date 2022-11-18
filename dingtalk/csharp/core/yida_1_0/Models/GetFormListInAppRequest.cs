// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetFormListInAppRequest : TeaModel {
        /// <summary>
        /// 应用编码。应用唯一标识。如：APP_XXX
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// 支持两种表单类型。
        /// receipt :  普通单据表单
        /// process ： 流程表单
        /// 如需查询多种类型，可用英文逗号分隔。
        /// 不传时默认单据和流程均返回。
        /// </summary>
        [NameInMap("formTypes")]
        [Validation(Required=false)]
        public string FormTypes { get; set; }

        /// <summary>
        /// 页码，不填默认为1。
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 单页返回的条目数，最大值100。
        /// 不填默认为100。
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 应用秘钥。在应用设置-部署运维-应用密钥中获取。
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// 操作人userId。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
