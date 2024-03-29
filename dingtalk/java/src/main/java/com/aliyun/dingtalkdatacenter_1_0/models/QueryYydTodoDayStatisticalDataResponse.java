// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTodoDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydTodoDayStatisticalDataResponseBody body;

    public static QueryYydTodoDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTodoDayStatisticalDataResponse self = new QueryYydTodoDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydTodoDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydTodoDayStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydTodoDayStatisticalDataResponse setBody(QueryYydTodoDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydTodoDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
