// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class GetMediaCerficateRequest : TeaModel {
        /// <summary>
        /// 视频的文件名称,必须带扩展名,支持的扩展名参考:https://help.aliyun.com/document_detail/55396.htm?spm=a2c4g.11186623.2.11.2d385d4aG2IkCZ#title-j7o-gr4-c7a
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// 入驻账号Id(请联系钉钉接口同学获取)
        /// </summary>
        [NameInMap("mcnId")]
        [Validation(Required=false)]
        public string McnId { get; set; }

        /// <summary>
        /// 如果传入该值，表示续订该mediaId对应的上传凭证 ;否则将视为新建一个视频上传连接和凭证
        /// </summary>
        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// 视频介绍
        /// </summary>
        [NameInMap("mediaIntroduction")]
        [Validation(Required=false)]
        public string MediaIntroduction { get; set; }

        /// <summary>
        /// 视频的标题
        /// </summary>
        [NameInMap("mediaTitle")]
        [Validation(Required=false)]
        public string MediaTitle { get; set; }

        /// <summary>
        /// 自定义视频封面的URL地址
        /// </summary>
        [NameInMap("thumbUrl")]
        [Validation(Required=false)]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// 操作人的用户id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
