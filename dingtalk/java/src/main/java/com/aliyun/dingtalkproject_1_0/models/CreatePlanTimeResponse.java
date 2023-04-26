// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreatePlanTimeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreatePlanTimeResponseBody body;

    public static CreatePlanTimeResponse build(java.util.Map<String, ?> map) throws Exception {
        CreatePlanTimeResponse self = new CreatePlanTimeResponse();
        return TeaModel.build(map, self);
    }

    public CreatePlanTimeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreatePlanTimeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreatePlanTimeResponse setBody(CreatePlanTimeResponseBody body) {
        this.body = body;
        return this;
    }
    public CreatePlanTimeResponseBody getBody() {
        return this.body;
    }

}
