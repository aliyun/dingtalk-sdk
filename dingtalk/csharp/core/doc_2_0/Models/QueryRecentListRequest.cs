// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class QueryRecentListRequest : TeaModel {
        /// <summary>
        /// 创建人类型。0-全部；1-我创建的；2-他人创建；不填也是查全部。
        /// </summary>
        [NameInMap("creatorType")]
        [Validation(Required=false)]
        public int? CreatorType { get; set; }

        /// <summary>
        /// 访问文档类型：0-文字；1-表格；2-PPT；3-白板；6-脑图；7-多维表；不填的话，则默认是所有。
        /// </summary>
        [NameInMap("fileType")]
        [Validation(Required=false)]
        public int? FileType { get; set; }

        /// <summary>
        /// 每页最大条目数，最大值10。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页游标，第一页可不传。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 操作用户unionId。
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 最近列表的类型：0-最近访问；1-最近编辑。
        /// </summary>
        [NameInMap("recentType")]
        [Validation(Required=false)]
        public int? RecentType { get; set; }

    }

}
