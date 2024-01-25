// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CreateTopboxResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateTopboxResponseBody body;

    public static CreateTopboxResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTopboxResponse self = new CreateTopboxResponse();
        return TeaModel.build(map, self);
    }

    public CreateTopboxResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTopboxResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateTopboxResponse setBody(CreateTopboxResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTopboxResponseBody getBody() {
        return this.body;
    }

}
