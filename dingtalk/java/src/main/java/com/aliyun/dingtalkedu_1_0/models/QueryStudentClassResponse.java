// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryStudentClassResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryStudentClassResponseBody body;

    public static QueryStudentClassResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryStudentClassResponse self = new QueryStudentClassResponse();
        return TeaModel.build(map, self);
    }

    public QueryStudentClassResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryStudentClassResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryStudentClassResponse setBody(QueryStudentClassResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryStudentClassResponseBody getBody() {
        return this.body;
    }

}
