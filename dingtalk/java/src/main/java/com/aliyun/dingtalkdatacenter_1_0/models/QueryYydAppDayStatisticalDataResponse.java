// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydAppDayStatisticalDataResponseBody body;

    public static QueryYydAppDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppDayStatisticalDataResponse self = new QueryYydAppDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydAppDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydAppDayStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydAppDayStatisticalDataResponse setBody(QueryYydAppDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydAppDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
