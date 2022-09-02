// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetDentryOpenInfoRequest : TeaModel {
        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public GetDentryOpenInfoRequestOption Option { get; set; }
        public class GetDentryOpenInfoRequestOption : TeaModel {
            /// <summary>
            /// 是否检查钉钉登录态, 目前仅对预览生效。
            /// 设置true时, 进入页面的时候会校验钉钉登录态。如果没有登录态, 会跳转到登录页面, 登录成功之后继续跳转到当前页面。
            /// 设置false时, 进入页面后不校验钉钉登录态, 但有以下的限制: 
            ///     1. 只支持WPS格式文件、有限图片格式, 不支持显示toolbar
            ///     2. 一个链接只能使用一次(针对浏览器session)
            ///     3. 链接5分钟不使用会失效
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("checkLogin")]
            [Validation(Required=false)]
            public bool? CheckLogin { get; set; }

            /// <summary>
            /// 打开方式，可以分为预览和编辑
            /// 枚举值:
            /// 	PREVIEW: 预览
            /// 	EDIT: 编辑
            /// 默认值:
            /// 	PREVIEW
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 历史版本号, 不填表示最新版本
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

            /// <summary>
            /// 是否需要水印
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("waterMark")]
            [Validation(Required=false)]
            public bool? WaterMark { get; set; }

        }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
