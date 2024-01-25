// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryUnionOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUnionOrderResponseBody body;

    public static QueryUnionOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUnionOrderResponse self = new QueryUnionOrderResponse();
        return TeaModel.build(map, self);
    }

    public QueryUnionOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUnionOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUnionOrderResponse setBody(QueryUnionOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUnionOrderResponseBody getBody() {
        return this.body;
    }

}
