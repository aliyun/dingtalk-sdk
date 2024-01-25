// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateInterconnectionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateInterconnectionResponseBody body;

    public static CreateInterconnectionResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateInterconnectionResponse self = new CreateInterconnectionResponse();
        return TeaModel.build(map, self);
    }

    public CreateInterconnectionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateInterconnectionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateInterconnectionResponse setBody(CreateInterconnectionResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateInterconnectionResponseBody getBody() {
        return this.body;
    }

}
