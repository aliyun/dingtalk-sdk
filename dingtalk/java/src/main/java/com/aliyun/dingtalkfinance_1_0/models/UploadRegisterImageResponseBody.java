// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadRegisterImageResponseBody extends TeaModel {
    // 进件图片上传响应
    @NameInMap("ossUrl")
    public String ossUrl;

    public static UploadRegisterImageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UploadRegisterImageResponseBody self = new UploadRegisterImageResponseBody();
        return TeaModel.build(map, self);
    }

    public UploadRegisterImageResponseBody setOssUrl(String ossUrl) {
        this.ossUrl = ossUrl;
        return this;
    }
    public String getOssUrl() {
        return this.ossUrl;
    }

}
