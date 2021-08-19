// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCalendarStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCalendarStatisticalDataResponseBody body;

    public static QueryCalendarStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCalendarStatisticalDataResponse self = new QueryCalendarStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryCalendarStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCalendarStatisticalDataResponse setBody(QueryCalendarStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCalendarStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
