// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripTrainOrderByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTripTrainOrderByPageResponseBody body;

    public static QueryTripTrainOrderByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTripTrainOrderByPageResponse self = new QueryTripTrainOrderByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryTripTrainOrderByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTripTrainOrderByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTripTrainOrderByPageResponse setBody(QueryTripTrainOrderByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTripTrainOrderByPageResponseBody getBody() {
        return this.body;
    }

}
