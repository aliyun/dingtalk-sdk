// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTodoMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydTodoMonthStatisticalDataResponseBody body;

    public static QueryYydTodoMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTodoMonthStatisticalDataResponse self = new QueryYydTodoMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydTodoMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydTodoMonthStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydTodoMonthStatisticalDataResponse setBody(QueryYydTodoMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydTodoMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
