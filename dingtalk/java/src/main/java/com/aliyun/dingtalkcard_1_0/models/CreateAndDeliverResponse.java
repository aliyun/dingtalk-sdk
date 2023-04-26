// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateAndDeliverResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateAndDeliverResponseBody body;

    public static CreateAndDeliverResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAndDeliverResponse self = new CreateAndDeliverResponse();
        return TeaModel.build(map, self);
    }

    public CreateAndDeliverResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAndDeliverResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAndDeliverResponse setBody(CreateAndDeliverResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAndDeliverResponseBody getBody() {
        return this.body;
    }

}
