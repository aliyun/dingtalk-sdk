// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchProjectCustomfieldRequest : TeaModel {
        /// <summary>
        /// 自定义字段ID集合，逗号组合。
        /// </summary>
        [NameInMap("customfieldIds")]
        [Validation(Required=false)]
        public string CustomfieldIds { get; set; }

        /// <summary>
        /// 字段InstanceId集合，用逗号组合。
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// 每页返回最大数量。默认10，最大500。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页标。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 过滤字段名字。
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// 任务类型ID。
        /// </summary>
        [NameInMap("scenariofieldconfigId")]
        [Validation(Required=false)]
        public string ScenariofieldconfigId { get; set; }

        /// <summary>
        /// 字段应用场景, 可以是 taskTableHeader,searcherAdd,taskExportHeader,sfcAdd,kanbanCardAdd,all 其中一个。
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
