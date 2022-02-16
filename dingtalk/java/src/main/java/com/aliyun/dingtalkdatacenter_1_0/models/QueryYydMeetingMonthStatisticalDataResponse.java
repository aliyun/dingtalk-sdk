// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydMeetingMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydMeetingMonthStatisticalDataResponseBody body;

    public static QueryYydMeetingMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydMeetingMonthStatisticalDataResponse self = new QueryYydMeetingMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydMeetingMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydMeetingMonthStatisticalDataResponse setBody(QueryYydMeetingMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydMeetingMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
