// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HUploadPackageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public HUploadPackageResponseBody body;

    public static HUploadPackageResponse build(java.util.Map<String, ?> map) throws Exception {
        HUploadPackageResponse self = new HUploadPackageResponse();
        return TeaModel.build(map, self);
    }

    public HUploadPackageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HUploadPackageResponse setBody(HUploadPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public HUploadPackageResponseBody getBody() {
        return this.body;
    }

}
