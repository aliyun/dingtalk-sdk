// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydLogDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydLogDayStatisticalDataResponseBody body;

    public static QueryYydLogDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydLogDayStatisticalDataResponse self = new QueryYydLogDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydLogDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydLogDayStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydLogDayStatisticalDataResponse setBody(QueryYydLogDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydLogDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
