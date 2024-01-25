// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class CreateSearchTabResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateSearchTabResponseBody body;

    public static CreateSearchTabResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSearchTabResponse self = new CreateSearchTabResponse();
        return TeaModel.build(map, self);
    }

    public CreateSearchTabResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSearchTabResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateSearchTabResponse setBody(CreateSearchTabResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSearchTabResponseBody getBody() {
        return this.body;
    }

}
