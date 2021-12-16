// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwms_1_0.models;

import com.aliyun.tea.*;

public class QueryGoodsListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryGoodsListResponseBody body;

    public static QueryGoodsListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGoodsListResponse self = new QueryGoodsListResponse();
        return TeaModel.build(map, self);
    }

    public QueryGoodsListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGoodsListResponse setBody(QueryGoodsListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGoodsListResponseBody getBody() {
        return this.body;
    }

}
