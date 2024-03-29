// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryTelMeetingStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public QueryTelMeetingStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTelMeetingStatisticalDataResponse setBody(QueryTelMeetingStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTelMeetingStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
