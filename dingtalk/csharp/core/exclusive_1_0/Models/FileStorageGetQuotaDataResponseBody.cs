// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class FileStorageGetQuotaDataResponseBody : TeaModel {
        [NameInMap("quotaModelList")]
        [Validation(Required=false)]
        public List<FileStorageGetQuotaDataResponseBodyQuotaModelList> QuotaModelList { get; set; }
        public class FileStorageGetQuotaDataResponseBodyQuotaModelList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("statisticTime")]
            [Validation(Required=false)]
            public string StatisticTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("usedStorage")]
            [Validation(Required=false)]
            public long? UsedStorage { get; set; }

        }

    }

}
