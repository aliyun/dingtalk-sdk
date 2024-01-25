// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityStudentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateUniversityStudentResponseBody body;

    public static CreateUniversityStudentResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateUniversityStudentResponse self = new CreateUniversityStudentResponse();
        return TeaModel.build(map, self);
    }

    public CreateUniversityStudentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateUniversityStudentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateUniversityStudentResponse setBody(CreateUniversityStudentResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateUniversityStudentResponseBody getBody() {
        return this.body;
    }

}
