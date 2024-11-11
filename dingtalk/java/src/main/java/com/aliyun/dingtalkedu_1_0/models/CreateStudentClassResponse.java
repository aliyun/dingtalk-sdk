// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateStudentClassResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateStudentClassResponseBody body;

    public static CreateStudentClassResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateStudentClassResponse self = new CreateStudentClassResponse();
        return TeaModel.build(map, self);
    }

    public CreateStudentClassResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateStudentClassResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateStudentClassResponse setBody(CreateStudentClassResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateStudentClassResponseBody getBody() {
        return this.body;
    }

}
