// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class CreateScreenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateScreenResponseBody body;

    public static CreateScreenResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateScreenResponse self = new CreateScreenResponse();
        return TeaModel.build(map, self);
    }

    public CreateScreenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateScreenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateScreenResponse setBody(CreateScreenResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateScreenResponseBody getBody() {
        return this.body;
    }

}
