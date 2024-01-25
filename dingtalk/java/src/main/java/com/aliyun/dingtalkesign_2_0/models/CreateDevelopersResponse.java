// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CreateDevelopersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateDevelopersResponseBody body;

    public static CreateDevelopersResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDevelopersResponse self = new CreateDevelopersResponse();
        return TeaModel.build(map, self);
    }

    public CreateDevelopersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateDevelopersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateDevelopersResponse setBody(CreateDevelopersResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateDevelopersResponseBody getBody() {
        return this.body;
    }

}
