// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QuerySignTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySignTaskResponseBody body;

    public static QuerySignTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySignTaskResponse self = new QuerySignTaskResponse();
        return TeaModel.build(map, self);
    }

    public QuerySignTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySignTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySignTaskResponse setBody(QuerySignTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySignTaskResponseBody getBody() {
        return this.body;
    }

}
