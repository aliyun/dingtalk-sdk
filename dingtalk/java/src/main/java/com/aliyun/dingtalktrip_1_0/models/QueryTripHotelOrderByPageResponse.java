// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripHotelOrderByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTripHotelOrderByPageResponseBody body;

    public static QueryTripHotelOrderByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTripHotelOrderByPageResponse self = new QueryTripHotelOrderByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryTripHotelOrderByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTripHotelOrderByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTripHotelOrderByPageResponse setBody(QueryTripHotelOrderByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTripHotelOrderByPageResponseBody getBody() {
        return this.body;
    }

}
