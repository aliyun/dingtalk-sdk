// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class SyncSignEventRequest : TeaModel {
        [NameInMap("contractBizId")]
        [Validation(Required=false)]
        public string ContractBizId { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtInfo { get; set; }

        [NameInMap("sealType")]
        [Validation(Required=false)]
        public List<string> SealType { get; set; }

        [NameInMap("signDate")]
        [Validation(Required=false)]
        public long? SignDate { get; set; }

        [NameInMap("signFileList")]
        [Validation(Required=false)]
        public List<SyncSignEventRequestSignFileList> SignFileList { get; set; }
        public class SyncSignEventRequestSignFileList : TeaModel {
            [NameInMap("fileDownloadUrl")]
            [Validation(Required=false)]
            public string FileDownloadUrl { get; set; }

            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

    }

}
