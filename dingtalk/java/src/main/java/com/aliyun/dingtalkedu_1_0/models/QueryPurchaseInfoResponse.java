// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPurchaseInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryPurchaseInfoResponseBody body;

    public static QueryPurchaseInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPurchaseInfoResponse self = new QueryPurchaseInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryPurchaseInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPurchaseInfoResponse setBody(QueryPurchaseInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPurchaseInfoResponseBody getBody() {
        return this.body;
    }

}
