// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class ExportPointOpenRequest : TeaModel {
        /// <summary>
        /// exportType为1时不需要传此参数，目前仅exportType=3时必须传入此参数,必须为七日内某一天且不能选择当日，格式yyyyMmdd。
        /// </summary>
        [NameInMap("exportDate")]
        [Validation(Required=false)]
        public string ExportDate { get; set; }

        /// <summary>
        /// 导出类型 1为七日内明细，3为七日内某一天榜单，且都不包含当日
        /// </summary>
        [NameInMap("exportType")]
        [Validation(Required=false)]
        public long? ExportType { get; set; }

        /// <summary>
        /// 操作人userId 必须为管理员
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
