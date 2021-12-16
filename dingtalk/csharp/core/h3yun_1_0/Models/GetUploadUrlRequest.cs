// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetUploadUrlRequest : TeaModel {
        /// <summary>
        /// 业务数据实例id
        /// </summary>
        [NameInMap("bizObjectId")]
        [Validation(Required=false)]
        public string BizObjectId { get; set; }

        /// <summary>
        /// 文件上传至目标控件的字段名
        /// </summary>
        [NameInMap("fieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// 是否覆盖。false=添加，true=覆盖
        /// </summary>
        [NameInMap("isOverwrite")]
        [Validation(Required=false)]
        public bool? IsOverwrite { get; set; }

        /// <summary>
        /// 表单编码
        /// </summary>
        [NameInMap("schemaCode")]
        [Validation(Required=false)]
        public string SchemaCode { get; set; }

    }

}
