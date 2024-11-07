// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryAccountTradeByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAccountTradeByPageResponseBody body;

    public static QueryAccountTradeByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAccountTradeByPageResponse self = new QueryAccountTradeByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryAccountTradeByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAccountTradeByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAccountTradeByPageResponse setBody(QueryAccountTradeByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAccountTradeByPageResponseBody getBody() {
        return this.body;
    }

}
