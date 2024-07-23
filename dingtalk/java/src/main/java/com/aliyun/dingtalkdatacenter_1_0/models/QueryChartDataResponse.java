// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryChartDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryChartDataResponseBody body;

    public static QueryChartDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryChartDataResponse self = new QueryChartDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryChartDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryChartDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryChartDataResponse setBody(QueryChartDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryChartDataResponseBody getBody() {
        return this.body;
    }

}
