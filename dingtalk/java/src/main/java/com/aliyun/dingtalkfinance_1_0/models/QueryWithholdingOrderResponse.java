// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryWithholdingOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryWithholdingOrderResponseBody body;

    public static QueryWithholdingOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryWithholdingOrderResponse self = new QueryWithholdingOrderResponse();
        return TeaModel.build(map, self);
    }

    public QueryWithholdingOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryWithholdingOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryWithholdingOrderResponse setBody(QueryWithholdingOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryWithholdingOrderResponseBody getBody() {
        return this.body;
    }

}
