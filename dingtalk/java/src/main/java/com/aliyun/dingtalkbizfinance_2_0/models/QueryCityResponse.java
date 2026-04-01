// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCityResponseBody body;

    public static QueryCityResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCityResponse self = new QueryCityResponse();
        return TeaModel.build(map, self);
    }

    public QueryCityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCityResponse setBody(QueryCityResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCityResponseBody getBody() {
        return this.body;
    }

}
