// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryAsrTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAsrTaskResponseBody body;

    public static QueryAsrTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAsrTaskResponse self = new QueryAsrTaskResponse();
        return TeaModel.build(map, self);
    }

    public QueryAsrTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAsrTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAsrTaskResponse setBody(QueryAsrTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAsrTaskResponseBody getBody() {
        return this.body;
    }

}
