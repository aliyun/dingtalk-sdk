// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HUploadPackageStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public HUploadPackageStatusResponseBody body;

    public static HUploadPackageStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        HUploadPackageStatusResponse self = new HUploadPackageStatusResponse();
        return TeaModel.build(map, self);
    }

    public HUploadPackageStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HUploadPackageStatusResponse setBody(HUploadPackageStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public HUploadPackageStatusResponseBody getBody() {
        return this.body;
    }

}
