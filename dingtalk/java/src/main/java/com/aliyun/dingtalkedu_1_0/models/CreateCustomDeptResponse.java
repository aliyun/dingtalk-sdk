// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateCustomDeptResponseBody body;

    public static CreateCustomDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomDeptResponse self = new CreateCustomDeptResponse();
        return TeaModel.build(map, self);
    }

    public CreateCustomDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCustomDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCustomDeptResponse setBody(CreateCustomDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCustomDeptResponseBody getBody() {
        return this.body;
    }

}
