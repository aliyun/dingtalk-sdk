// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydMeetingDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydMeetingDayStatisticalDataResponseBody body;

    public static QueryYydMeetingDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydMeetingDayStatisticalDataResponse self = new QueryYydMeetingDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydMeetingDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydMeetingDayStatisticalDataResponse setBody(QueryYydMeetingDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydMeetingDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
