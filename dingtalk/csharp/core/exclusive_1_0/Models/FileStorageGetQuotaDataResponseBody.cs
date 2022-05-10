// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class FileStorageGetQuotaDataResponseBody : TeaModel {
        /// <summary>
        /// 文件存储使用容量列表
        /// </summary>
        [NameInMap("quotaModelList")]
        [Validation(Required=false)]
        public List<FileStorageGetQuotaDataResponseBodyQuotaModelList> QuotaModelList { get; set; }
        public class FileStorageGetQuotaDataResponseBodyQuotaModelList : TeaModel {
            /// <summary>
            /// 统计时间点
            /// </summary>
            [NameInMap("statisticTime")]
            [Validation(Required=false)]
            public string StatisticTime { get; set; }

            /// <summary>
            /// 使用的容量（byte）
            /// </summary>
            [NameInMap("usedStorage")]
            [Validation(Required=false)]
            public long? UsedStorage { get; set; }

        }

    }

}
