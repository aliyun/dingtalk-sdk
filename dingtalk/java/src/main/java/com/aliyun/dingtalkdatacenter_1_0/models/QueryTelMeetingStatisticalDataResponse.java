// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryTelMeetingStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryTelMeetingStatisticalDataResponseBody body;

    public static QueryTelMeetingStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTelMeetingStatisticalDataResponse self = new QueryTelMeetingStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryTelMeetingStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTelMeetingStatisticalDataResponse setBody(QueryTelMeetingStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTelMeetingStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
