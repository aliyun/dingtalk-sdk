// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityStudentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteUniversityStudentResponseBody body;

    public static DeleteUniversityStudentResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteUniversityStudentResponse self = new DeleteUniversityStudentResponse();
        return TeaModel.build(map, self);
    }

    public DeleteUniversityStudentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteUniversityStudentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteUniversityStudentResponse setBody(DeleteUniversityStudentResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteUniversityStudentResponseBody getBody() {
        return this.body;
    }

}
