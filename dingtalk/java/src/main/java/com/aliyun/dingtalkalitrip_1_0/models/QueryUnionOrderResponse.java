// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryUnionOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryUnionOrderResponse setBody(QueryUnionOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUnionOrderResponseBody getBody() {
        return this.body;
    }

}
