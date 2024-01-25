// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCalendarStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCalendarStatisticalDataResponseBody body;

    public static QueryCalendarStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCalendarStatisticalDataResponse self = new QueryCalendarStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryCalendarStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCalendarStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCalendarStatisticalDataResponse setBody(QueryCalendarStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCalendarStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
