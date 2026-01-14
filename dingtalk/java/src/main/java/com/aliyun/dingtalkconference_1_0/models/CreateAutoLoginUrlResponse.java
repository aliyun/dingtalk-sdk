// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateAutoLoginUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAutoLoginUrlResponseBody body;

    public static CreateAutoLoginUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAutoLoginUrlResponse self = new CreateAutoLoginUrlResponse();
        return TeaModel.build(map, self);
    }

    public CreateAutoLoginUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAutoLoginUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAutoLoginUrlResponse setBody(CreateAutoLoginUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAutoLoginUrlResponseBody getBody() {
        return this.body;
    }

}
