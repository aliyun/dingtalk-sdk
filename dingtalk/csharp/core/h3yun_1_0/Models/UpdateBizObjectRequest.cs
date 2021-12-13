// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class UpdateBizObjectRequest : TeaModel {
        /// <summary>
        /// 业务数据id
        /// </summary>
        [NameInMap("bizObjectId")]
        [Validation(Required=false)]
        public string BizObjectId { get; set; }

        /// <summary>
        /// 待修改的json格式业务数据
        /// </summary>
        [NameInMap("bizObjectJson")]
        [Validation(Required=false)]
        public string BizObjectJson { get; set; }

        /// <summary>
        /// 表单编码
        /// </summary>
        [NameInMap("schemaCode")]
        [Validation(Required=false)]
        public string SchemaCode { get; set; }

    }

}
