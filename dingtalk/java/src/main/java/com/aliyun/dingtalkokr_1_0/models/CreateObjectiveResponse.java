// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateObjectiveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateObjectiveResponseBody body;

    public static CreateObjectiveResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateObjectiveResponse self = new CreateObjectiveResponse();
        return TeaModel.build(map, self);
    }

    public CreateObjectiveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateObjectiveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateObjectiveResponse setBody(CreateObjectiveResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateObjectiveResponseBody getBody() {
        return this.body;
    }

}
