// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySnsOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QuerySnsOrderResponse setBody(QuerySnsOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySnsOrderResponseBody getBody() {
        return this.body;
    }

}
