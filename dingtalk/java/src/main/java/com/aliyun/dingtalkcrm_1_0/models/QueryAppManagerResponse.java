// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAppManagerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAppManagerResponseBody body;

    public static QueryAppManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAppManagerResponse self = new QueryAppManagerResponse();
        return TeaModel.build(map, self);
    }

    public QueryAppManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAppManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAppManagerResponse setBody(QueryAppManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAppManagerResponseBody getBody() {
        return this.body;
    }

}
