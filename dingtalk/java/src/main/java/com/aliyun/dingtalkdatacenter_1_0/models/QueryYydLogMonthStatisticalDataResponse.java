// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydLogMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydLogMonthStatisticalDataResponseBody body;

    public static QueryYydLogMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydLogMonthStatisticalDataResponse self = new QueryYydLogMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydLogMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydLogMonthStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydLogMonthStatisticalDataResponse setBody(QueryYydLogMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydLogMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
