// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryGlobalInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGlobalInfoResponseBody body;

    public static QueryGlobalInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGlobalInfoResponse self = new QueryGlobalInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryGlobalInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGlobalInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGlobalInfoResponse setBody(QueryGlobalInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGlobalInfoResponseBody getBody() {
        return this.body;
    }

}
