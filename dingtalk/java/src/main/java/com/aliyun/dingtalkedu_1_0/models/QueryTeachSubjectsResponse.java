// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryTeachSubjectsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTeachSubjectsResponseBody body;

    public static QueryTeachSubjectsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTeachSubjectsResponse self = new QueryTeachSubjectsResponse();
        return TeaModel.build(map, self);
    }

    public QueryTeachSubjectsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTeachSubjectsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTeachSubjectsResponse setBody(QueryTeachSubjectsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTeachSubjectsResponseBody getBody() {
        return this.body;
    }

}
