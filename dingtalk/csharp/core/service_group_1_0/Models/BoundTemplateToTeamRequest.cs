// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BoundTemplateToTeamRequest : TeaModel {
        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 目标团队id
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 模板中的机器人配置信息
        /// </summary>
        [NameInMap("robotConfig")]
        [Validation(Required=false)]
        public string RobotConfig { get; set; }

        /// <summary>
        /// 模板描述信息
        /// </summary>
        [NameInMap("templateDesc")]
        [Validation(Required=false)]
        public string TemplateDesc { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名字
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
