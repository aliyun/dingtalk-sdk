// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydCalendarWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydCalendarWeekStatisticalDataResponseBody body;

    public static QueryYydCalendarWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydCalendarWeekStatisticalDataResponse self = new QueryYydCalendarWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydCalendarWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydCalendarWeekStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydCalendarWeekStatisticalDataResponse setBody(QueryYydCalendarWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydCalendarWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
