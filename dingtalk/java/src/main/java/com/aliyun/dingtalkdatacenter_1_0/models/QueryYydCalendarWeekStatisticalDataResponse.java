// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydCalendarWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryYydCalendarWeekStatisticalDataResponse setBody(QueryYydCalendarWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydCalendarWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
