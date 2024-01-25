// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwms_1_0.models;

import com.aliyun.tea.*;

public class QueryGoodsListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public QueryGoodsListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGoodsListResponse setBody(QueryGoodsListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGoodsListResponseBody getBody() {
        return this.body;
    }

}
