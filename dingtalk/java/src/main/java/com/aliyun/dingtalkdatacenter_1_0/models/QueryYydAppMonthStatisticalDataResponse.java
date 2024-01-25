// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydAppMonthStatisticalDataResponseBody body;

    public static QueryYydAppMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppMonthStatisticalDataResponse self = new QueryYydAppMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydAppMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydAppMonthStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydAppMonthStatisticalDataResponse setBody(QueryYydAppMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydAppMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
