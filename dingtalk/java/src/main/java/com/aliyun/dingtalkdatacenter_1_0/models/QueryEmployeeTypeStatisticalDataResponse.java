// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryEmployeeTypeStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryEmployeeTypeStatisticalDataResponseBody body;

    public static QueryEmployeeTypeStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryEmployeeTypeStatisticalDataResponse self = new QueryEmployeeTypeStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryEmployeeTypeStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryEmployeeTypeStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryEmployeeTypeStatisticalDataResponse setBody(QueryEmployeeTypeStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryEmployeeTypeStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
