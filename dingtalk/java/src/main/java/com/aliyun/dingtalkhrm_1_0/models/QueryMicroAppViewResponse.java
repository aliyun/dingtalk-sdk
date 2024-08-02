// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryMicroAppViewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMicroAppViewResponseBody body;

    public static QueryMicroAppViewResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMicroAppViewResponse self = new QueryMicroAppViewResponse();
        return TeaModel.build(map, self);
    }

    public QueryMicroAppViewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMicroAppViewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMicroAppViewResponse setBody(QueryMicroAppViewResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMicroAppViewResponseBody getBody() {
        return this.body;
    }

}
