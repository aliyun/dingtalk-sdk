// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySubjectTeachersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySubjectTeachersResponseBody body;

    public static QuerySubjectTeachersResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySubjectTeachersResponse self = new QuerySubjectTeachersResponse();
        return TeaModel.build(map, self);
    }

    public QuerySubjectTeachersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySubjectTeachersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySubjectTeachersResponse setBody(QuerySubjectTeachersResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySubjectTeachersResponseBody getBody() {
        return this.body;
    }

}
