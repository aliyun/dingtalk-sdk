// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydActiveWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydActiveWeekStatisticalDataResponseBody body;

    public static QueryYydActiveWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydActiveWeekStatisticalDataResponse self = new QueryYydActiveWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydActiveWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydActiveWeekStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydActiveWeekStatisticalDataResponse setBody(QueryYydActiveWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydActiveWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
