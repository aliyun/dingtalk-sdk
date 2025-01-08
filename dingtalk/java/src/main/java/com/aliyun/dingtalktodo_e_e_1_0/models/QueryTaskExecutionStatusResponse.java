// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class QueryTaskExecutionStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTaskExecutionStatusResponseBody body;

    public static QueryTaskExecutionStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTaskExecutionStatusResponse self = new QueryTaskExecutionStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryTaskExecutionStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTaskExecutionStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTaskExecutionStatusResponse setBody(QueryTaskExecutionStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTaskExecutionStatusResponseBody getBody() {
        return this.body;
    }

}
