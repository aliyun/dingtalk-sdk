// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPrivateStoreFileInfosByPageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>文档文件:document, 视频:video, 代码文件:text, 链接:link, 音频:audio, 图片:image, 压缩文件:archive, 安装包:app, 其他:other</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("deptIds")]
        [Validation(Required=false)]
        public List<long?> DeptIds { get; set; }

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

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <b>Example:</b>
        /// <para>IM:IM, 其他:OTHER, 个人空间:PERSON, 企业内共享:ORG</para>
        /// </summary>
        [NameInMap("sceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
