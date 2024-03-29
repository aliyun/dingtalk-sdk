// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySnsOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySnsOrderResponseBody body;

    public static QuerySnsOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySnsOrderResponse self = new QuerySnsOrderResponse();
        return TeaModel.build(map, self);
    }

    public QuerySnsOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySnsOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySnsOrderResponse setBody(QuerySnsOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySnsOrderResponseBody getBody() {
        return this.body;
    }

}
