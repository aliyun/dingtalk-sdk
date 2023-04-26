// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryCollectingTraceTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCollectingTraceTaskResponseBody body;

    public static QueryCollectingTraceTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectingTraceTaskResponse self = new QueryCollectingTraceTaskResponse();
        return TeaModel.build(map, self);
    }

    public QueryCollectingTraceTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCollectingTraceTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCollectingTraceTaskResponse setBody(QueryCollectingTraceTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCollectingTraceTaskResponseBody getBody() {
        return this.body;
    }

}
