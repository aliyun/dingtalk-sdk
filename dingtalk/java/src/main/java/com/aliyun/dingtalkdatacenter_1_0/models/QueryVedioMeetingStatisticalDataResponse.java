// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryVedioMeetingStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryVedioMeetingStatisticalDataResponseBody body;

    public static QueryVedioMeetingStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryVedioMeetingStatisticalDataResponse self = new QueryVedioMeetingStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryVedioMeetingStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryVedioMeetingStatisticalDataResponse setBody(QueryVedioMeetingStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryVedioMeetingStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
