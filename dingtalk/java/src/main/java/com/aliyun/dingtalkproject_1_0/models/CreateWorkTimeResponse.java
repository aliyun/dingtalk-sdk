// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkTimeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateWorkTimeResponseBody body;

    public static CreateWorkTimeResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateWorkTimeResponse self = new CreateWorkTimeResponse();
        return TeaModel.build(map, self);
    }

    public CreateWorkTimeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateWorkTimeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateWorkTimeResponse setBody(CreateWorkTimeResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateWorkTimeResponseBody getBody() {
        return this.body;
    }

}
