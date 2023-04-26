// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydCalendarDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydCalendarDayStatisticalDataResponseBody body;

    public static QueryYydCalendarDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydCalendarDayStatisticalDataResponse self = new QueryYydCalendarDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydCalendarDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydCalendarDayStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydCalendarDayStatisticalDataResponse setBody(QueryYydCalendarDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydCalendarDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
