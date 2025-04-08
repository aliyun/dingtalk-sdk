// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPrivateStoreFileInfosByPageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1680493837426</para>
        /// </summary>
        [NameInMap("fileCreateTime")]
        [Validation(Required=false)]
        public long? FileCreateTime { get; set; }

        [NameInMap("fileStatus")]
        [Validation(Required=false)]
        public string FileStatus { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

    }

}
