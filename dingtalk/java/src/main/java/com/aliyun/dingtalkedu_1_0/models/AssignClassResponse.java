// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AssignClassResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AssignClassResponseBody body;

    public static AssignClassResponse build(java.util.Map<String, ?> map) throws Exception {
        AssignClassResponse self = new AssignClassResponse();
        return TeaModel.build(map, self);
    }

    public AssignClassResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AssignClassResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AssignClassResponse setBody(AssignClassResponseBody body) {
        this.body = body;
        return this;
    }
    public AssignClassResponseBody getBody() {
        return this.body;
    }

}
