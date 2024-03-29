// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class QueryInterviewsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryInterviewsResponseBody body;

    public static QueryInterviewsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryInterviewsResponse self = new QueryInterviewsResponse();
        return TeaModel.build(map, self);
    }

    public QueryInterviewsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryInterviewsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryInterviewsResponse setBody(QueryInterviewsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryInterviewsResponseBody getBody() {
        return this.body;
    }

}
