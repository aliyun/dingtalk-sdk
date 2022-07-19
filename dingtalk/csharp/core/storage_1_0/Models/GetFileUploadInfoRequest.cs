// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetFileUploadInfoRequest : TeaModel {
        /// <summary>
        /// 是否需要分片上传
        /// 5G以下文件，建议设为false，简化上传步骤
        /// 5G以上文件，必须设为true, 否则上传会失败
        /// 具体参考文档: https://help.aliyun.com/document_detail/84778.html
        /// </summary>
        [NameInMap("multipart")]
        [Validation(Required=false)]
        public bool? Multipart { get; set; }

        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public GetFileUploadInfoRequestOption Option { get; set; }
        public class GetFileUploadInfoRequestOption : TeaModel {
            [NameInMap("preCheckParam")]
            [Validation(Required=false)]
            public GetFileUploadInfoRequestOptionPreCheckParam PreCheckParam { get; set; }
            public class GetFileUploadInfoRequestOptionPreCheckParam : TeaModel {
                /// <summary>
                /// 文件md5值, 做文件完整性校验。不传则不做校验。
                /// </summary>
                [NameInMap("md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                /// <summary>
                /// 文件名称, 文件名称合法性和文件名称冲突校验
                /// 规则：
                /// 1. 头尾不能包含空格，否则会自动去除
                /// 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
                /// 3. 不能以"."结尾
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 父目录id
                /// 根目录id值为0
                /// 用于同目录文件名冲突校验
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// 文件大小, 做容量相关校验。不传则不做校验。
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }
            [NameInMap("preferRegion")]
            [Validation(Required=false)]
            public string PreferRegion { get; set; }
            [NameInMap("storageDriver")]
            [Validation(Required=false)]
            public string StorageDriver { get; set; }
        };

        /// <summary>
        /// 通过指定上传协议返回不同协议上传所需要的信息
        /// 对于部分企业开启了专属存储，必须实现HEADER加签，否则无法支持专属存储组织文件上传。
        /// 如果指定上传协议不支持，则会返回错误Errors.DENTRY_UPLOAD_PROTOCOL_NOTSUPPORT, 请尝试用其它协议上传。
        /// 枚举值:
        /// 	HEADER_SIGNATURE: Header加签
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
