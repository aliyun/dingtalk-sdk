// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QuerySalesInsightsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySalesInsightsResponseBody body;

    public static QuerySalesInsightsResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySalesInsightsResponse self = new QuerySalesInsightsResponse();
        return TeaModel.build(map, self);
    }

    public QuerySalesInsightsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySalesInsightsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySalesInsightsResponse setBody(QuerySalesInsightsResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySalesInsightsResponseBody getBody() {
        return this.body;
    }

}
