// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class PullDataByPageRequest : TeaModel {
        /// <summary>
        /// 要拉取的主数据模型id。
        /// </summary>
        [NameInMap("dataModelId")]
        [Validation(Required=false)]
        public string DataModelId { get; set; }

        /// <summary>
        /// 用于过滤时间范围的字段，包含数据创建时间(dataGmtCreate)和数据修改时间(dataGmtModified)，如不传则不过滤。
        /// </summary>
        [NameInMap("datetimeFilterField")]
        [Validation(Required=false)]
        public string DatetimeFilterField { get; set; }

        /// <summary>
        /// 当配置了datetimeFilterField字段后，数据的时间起点，如果不传则将最早一条数据作为起点。
        /// </summary>
        [NameInMap("minDatetime")]
        [Validation(Required=false)]
        public long? MinDatetime { get; set; }

        /// <summary>
        /// 当配置了datetimeFilterField字段后，数据的时间终点，如果不传则按最新一条数据作为终点。
        /// </summary>
        [NameInMap("maxDatetime")]
        [Validation(Required=false)]
        public long? MaxDatetime { get; set; }

        /// <summary>
        /// 用于翻页的游标，如果为空则从第一条数据开始查询。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 单次获取的最大记录条数，最大限制100条。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

    }

}
