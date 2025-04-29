// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateStudentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateStudentResponseBody body;

    public static UpdateStudentResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateStudentResponse self = new UpdateStudentResponse();
        return TeaModel.build(map, self);
    }

    public UpdateStudentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateStudentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateStudentResponse setBody(UpdateStudentResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateStudentResponseBody getBody() {
        return this.body;
    }

}
