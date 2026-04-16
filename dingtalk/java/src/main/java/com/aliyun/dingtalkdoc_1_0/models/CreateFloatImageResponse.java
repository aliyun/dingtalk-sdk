// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateFloatImageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateFloatImageResponseBody body;

    public static CreateFloatImageResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateFloatImageResponse self = new CreateFloatImageResponse();
        return TeaModel.build(map, self);
    }

    public CreateFloatImageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateFloatImageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateFloatImageResponse setBody(CreateFloatImageResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateFloatImageResponseBody getBody() {
        return this.body;
    }

}
