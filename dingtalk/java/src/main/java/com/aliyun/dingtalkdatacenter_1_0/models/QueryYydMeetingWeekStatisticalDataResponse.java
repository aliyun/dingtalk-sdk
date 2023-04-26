// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydMeetingWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydMeetingWeekStatisticalDataResponseBody body;

    public static QueryYydMeetingWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydMeetingWeekStatisticalDataResponse self = new QueryYydMeetingWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydMeetingWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydMeetingWeekStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydMeetingWeekStatisticalDataResponse setBody(QueryYydMeetingWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydMeetingWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
