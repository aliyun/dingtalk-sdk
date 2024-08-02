// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryMicroAppStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMicroAppStatusResponseBody body;

    public static QueryMicroAppStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMicroAppStatusResponse self = new QueryMicroAppStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryMicroAppStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMicroAppStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMicroAppStatusResponse setBody(QueryMicroAppStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMicroAppStatusResponseBody getBody() {
        return this.body;
    }

}
