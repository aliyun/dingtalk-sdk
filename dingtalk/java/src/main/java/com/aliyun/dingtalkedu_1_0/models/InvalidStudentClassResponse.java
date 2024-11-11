// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InvalidStudentClassResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InvalidStudentClassResponseBody body;

    public static InvalidStudentClassResponse build(java.util.Map<String, ?> map) throws Exception {
        InvalidStudentClassResponse self = new InvalidStudentClassResponse();
        return TeaModel.build(map, self);
    }

    public InvalidStudentClassResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InvalidStudentClassResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InvalidStudentClassResponse setBody(InvalidStudentClassResponseBody body) {
        this.body = body;
        return this;
    }
    public InvalidStudentClassResponseBody getBody() {
        return this.body;
    }

}
