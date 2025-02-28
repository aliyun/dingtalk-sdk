// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCollectionInfoListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCollectionInfoListResponseBody body;

    public static QueryCollectionInfoListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectionInfoListResponse self = new QueryCollectionInfoListResponse();
        return TeaModel.build(map, self);
    }

    public QueryCollectionInfoListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCollectionInfoListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCollectionInfoListResponse setBody(QueryCollectionInfoListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCollectionInfoListResponseBody getBody() {
        return this.body;
    }

}
