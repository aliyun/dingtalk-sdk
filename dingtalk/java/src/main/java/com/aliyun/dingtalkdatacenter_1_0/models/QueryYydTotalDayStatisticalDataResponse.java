// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydTotalDayStatisticalDataResponseBody body;

    public static QueryYydTotalDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalDayStatisticalDataResponse self = new QueryYydTotalDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydTotalDayStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydTotalDayStatisticalDataResponse setBody(QueryYydTotalDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydTotalDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
