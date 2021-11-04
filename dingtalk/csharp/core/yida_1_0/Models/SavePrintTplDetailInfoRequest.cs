// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class SavePrintTplDetailInfoRequest : TeaModel {
        /// <summary>
        /// 应用代码
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 文件名配置
        /// </summary>
        [NameInMap("fileNameConfig")]
        [Validation(Required=false)]
        public string FileNameConfig { get; set; }

        /// <summary>
        /// 表单id
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// 表单版本
        /// </summary>
        [NameInMap("formVersion")]
        [Validation(Required=false)]
        public int? FormVersion { get; set; }

        /// <summary>
        /// 模板的其他配置信息
        /// </summary>
        [NameInMap("setting")]
        [Validation(Required=false)]
        public string Setting { get; set; }

        /// <summary>
        /// 打印模板id
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// 模板标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 模板的VM
        /// </summary>
        [NameInMap("vm")]
        [Validation(Required=false)]
        public string Vm { get; set; }

    }

}
