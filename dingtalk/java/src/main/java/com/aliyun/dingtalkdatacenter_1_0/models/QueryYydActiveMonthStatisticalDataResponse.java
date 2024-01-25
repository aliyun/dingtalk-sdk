// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydActiveMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydActiveMonthStatisticalDataResponseBody body;

    public static QueryYydActiveMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydActiveMonthStatisticalDataResponse self = new QueryYydActiveMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydActiveMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydActiveMonthStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydActiveMonthStatisticalDataResponse setBody(QueryYydActiveMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydActiveMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
