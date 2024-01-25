// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteStudentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteStudentResponseBody body;

    public static DeleteStudentResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteStudentResponse self = new DeleteStudentResponse();
        return TeaModel.build(map, self);
    }

    public DeleteStudentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteStudentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteStudentResponse setBody(DeleteStudentResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteStudentResponseBody getBody() {
        return this.body;
    }

}
