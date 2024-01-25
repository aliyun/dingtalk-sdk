// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryAttendanceStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAttendanceStatisticalDataResponseBody body;

    public static QueryAttendanceStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAttendanceStatisticalDataResponse self = new QueryAttendanceStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryAttendanceStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAttendanceStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAttendanceStatisticalDataResponse setBody(QueryAttendanceStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAttendanceStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
