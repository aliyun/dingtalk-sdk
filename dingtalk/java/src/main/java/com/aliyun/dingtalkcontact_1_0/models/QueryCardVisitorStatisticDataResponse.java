// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCardVisitorStatisticDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCardVisitorStatisticDataResponseBody body;

    public static QueryCardVisitorStatisticDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCardVisitorStatisticDataResponse self = new QueryCardVisitorStatisticDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryCardVisitorStatisticDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCardVisitorStatisticDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCardVisitorStatisticDataResponse setBody(QueryCardVisitorStatisticDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCardVisitorStatisticDataResponseBody getBody() {
        return this.body;
    }

}
