// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryAttendanceStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryAttendanceStatisticalDataResponse setBody(QueryAttendanceStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAttendanceStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
