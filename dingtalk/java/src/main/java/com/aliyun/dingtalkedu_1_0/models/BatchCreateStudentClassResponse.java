// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateStudentClassResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchCreateStudentClassResponseBody body;

    public static BatchCreateStudentClassResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateStudentClassResponse self = new BatchCreateStudentClassResponse();
        return TeaModel.build(map, self);
    }

    public BatchCreateStudentClassResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchCreateStudentClassResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchCreateStudentClassResponse setBody(BatchCreateStudentClassResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchCreateStudentClassResponseBody getBody() {
        return this.body;
    }

}
