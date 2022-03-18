// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class AddCustomerTrackRequest : TeaModel {
        /// <summary>
        /// 动态内容,markdown格式
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [NameInMap("customerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 任意业务自定义的数据，可空
        /// </summary>
        [NameInMap("extraBizInfo")]
        [Validation(Required=false)]
        public string ExtraBizInfo { get; set; }

        /// <summary>
        /// 幂等key，5分钟内避免重复写入，保证幂等，可空
        /// </summary>
        [NameInMap("idempotentKey")]
        [Validation(Required=false)]
        public string IdempotentKey { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// 动态标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 动态的类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
