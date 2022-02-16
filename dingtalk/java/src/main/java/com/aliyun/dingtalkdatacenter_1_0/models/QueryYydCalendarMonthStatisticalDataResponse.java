// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydCalendarMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryYydCalendarMonthStatisticalDataResponse setBody(QueryYydCalendarMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydCalendarMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
