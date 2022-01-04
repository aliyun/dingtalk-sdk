// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadRegisterImageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UploadRegisterImageResponseBody body;

    public static UploadRegisterImageResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadRegisterImageResponse self = new UploadRegisterImageResponse();
        return TeaModel.build(map, self);
    }

    public UploadRegisterImageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UploadRegisterImageResponse setBody(UploadRegisterImageResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadRegisterImageResponseBody getBody() {
        return this.body;
    }

}
