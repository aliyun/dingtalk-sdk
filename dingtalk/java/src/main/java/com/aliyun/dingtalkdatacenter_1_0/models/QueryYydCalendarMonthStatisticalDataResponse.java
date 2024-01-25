// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydCalendarMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydCalendarMonthStatisticalDataResponseBody body;

    public static QueryYydCalendarMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydCalendarMonthStatisticalDataResponse self = new QueryYydCalendarMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydCalendarMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydCalendarMonthStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydCalendarMonthStatisticalDataResponse setBody(QueryYydCalendarMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydCalendarMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
