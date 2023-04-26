// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitCoursesOfClassResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public InitCoursesOfClassResponseBody body;

    public static InitCoursesOfClassResponse build(java.util.Map<String, ?> map) throws Exception {
        InitCoursesOfClassResponse self = new InitCoursesOfClassResponse();
        return TeaModel.build(map, self);
    }

    public InitCoursesOfClassResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InitCoursesOfClassResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InitCoursesOfClassResponse setBody(InitCoursesOfClassResponseBody body) {
        this.body = body;
        return this;
    }
    public InitCoursesOfClassResponseBody getBody() {
        return this.body;
    }

}
