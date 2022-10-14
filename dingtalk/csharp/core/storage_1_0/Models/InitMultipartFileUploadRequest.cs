// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class InitMultipartFileUploadRequest : TeaModel {
        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public InitMultipartFileUploadRequestOption Option { get; set; }
        public class InitMultipartFileUploadRequestOption : TeaModel {
            /// <summary>
            /// 预检查的字段。可实现对文件名称，文件完整性，容量的校验
            /// </summary>
            [NameInMap("preCheckParam")]
            [Validation(Required=false)]
            public InitMultipartFileUploadRequestOptionPreCheckParam PreCheckParam { get; set; }
            public class InitMultipartFileUploadRequestOptionPreCheckParam : TeaModel {
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

            /// <summary>
            /// 优先地域, 倾向于将资源存到哪个地域，可实现就近上传等功能
            /// 枚举值:
            /// 	ZHANGJIAKOU: 张家口
            /// 	SHENZHEN: 深圳
            /// 	SHANGHAI: 上海
            /// 	SINGAPORE: 新加坡
            /// 	UNKNOWN: 未知
            /// </summary>
            [NameInMap("preferRegion")]
            [Validation(Required=false)]
            public string PreferRegion { get; set; }

            /// <summary>
            /// 文件存储驱动类型, 当前只支持DINGTALK
            /// 枚举值:
            /// 	DINGTALK: 钉钉统一存储驱动
            /// 	ALIDOC: 钉钉文档存储驱动
            /// 	SHANJI: 闪记存储驱动
            /// 	UNKNOWN: 未知驱动
            /// 默认值:
            /// 	DINGTALK
            /// </summary>
            [NameInMap("storageDriver")]
            [Validation(Required=false)]
            public string StorageDriver { get; set; }

        }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
