// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripFlightOrderByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTripFlightOrderByPageResponseBody body;

    public static QueryTripFlightOrderByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTripFlightOrderByPageResponse self = new QueryTripFlightOrderByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryTripFlightOrderByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTripFlightOrderByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTripFlightOrderByPageResponse setBody(QueryTripFlightOrderByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTripFlightOrderByPageResponseBody getBody() {
        return this.body;
    }

}
