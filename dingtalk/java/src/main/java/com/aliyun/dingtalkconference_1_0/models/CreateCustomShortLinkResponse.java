// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomShortLinkResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCustomShortLinkResponseBody body;

    public static CreateCustomShortLinkResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomShortLinkResponse self = new CreateCustomShortLinkResponse();
        return TeaModel.build(map, self);
    }

    public CreateCustomShortLinkResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCustomShortLinkResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCustomShortLinkResponse setBody(CreateCustomShortLinkResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCustomShortLinkResponseBody getBody() {
        return this.body;
    }

}
