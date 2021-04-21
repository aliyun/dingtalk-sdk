// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddKnowledgeRequest : TeaModel {
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
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 知识库的唯一标识
        /// </summary>
        [NameInMap("libraryKey")]
        [Validation(Required=false)]
        public string LibraryKey { get; set; }

        /// <summary>
        /// 知识点来源
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 知识点唯一标识
        /// </summary>
        [NameInMap("sourcePrimaryKey")]
        [Validation(Required=false)]
        public string SourcePrimaryKey { get; set; }

        /// <summary>
        /// 知识点类型 NORMAL：普通型 CARD：卡片 CONDITION：条件
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 知识点名称
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 知识点内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// CCM的知识点外链
        /// </summary>
        [NameInMap("linkUrl")]
        [Validation(Required=false)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 知识点版本号
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
