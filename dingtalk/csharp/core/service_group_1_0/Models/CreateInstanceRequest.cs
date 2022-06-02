// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// 渠道
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// 外部业务ID，由英文、数字构成
        /// </summary>
        [NameInMap("externalBizId")]
        [Validation(Required=false)]
        public string ExternalBizId { get; set; }

        /// <summary>
        /// 表单CODE,客户表单：DING_CUSTOMER；联系人表单：DING_CONTACT
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// 表单数据，JSON格式
        /// </summary>
        [NameInMap("formDataList")]
        [Validation(Required=false)]
        public string FormDataList { get; set; }

        /// <summary>
        /// 开放团队ID，从服务群后台ID信息中获取
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

        /// <summary>
        /// 拥有人unionId
        /// </summary>
        [NameInMap("ownerUnionId")]
        [Validation(Required=false)]
        public string OwnerUnionId { get; set; }

    }

}
