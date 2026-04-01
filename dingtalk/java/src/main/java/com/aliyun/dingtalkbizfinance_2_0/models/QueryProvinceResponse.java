// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryProvinceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryProvinceResponseBody body;

    public static QueryProvinceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryProvinceResponse self = new QueryProvinceResponse();
        return TeaModel.build(map, self);
    }

    public QueryProvinceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryProvinceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryProvinceResponse setBody(QueryProvinceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryProvinceResponseBody getBody() {
        return this.body;
    }

}
