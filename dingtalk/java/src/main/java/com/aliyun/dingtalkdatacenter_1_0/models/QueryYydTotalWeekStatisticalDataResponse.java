// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydTotalWeekStatisticalDataResponseBody body;

    public static QueryYydTotalWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalWeekStatisticalDataResponse self = new QueryYydTotalWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydTotalWeekStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydTotalWeekStatisticalDataResponse setBody(QueryYydTotalWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydTotalWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
