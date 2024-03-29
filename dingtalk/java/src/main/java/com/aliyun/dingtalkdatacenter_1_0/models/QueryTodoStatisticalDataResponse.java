// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryTodoStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTodoStatisticalDataResponseBody body;

    public static QueryTodoStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTodoStatisticalDataResponse self = new QueryTodoStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryTodoStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTodoStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTodoStatisticalDataResponse setBody(QueryTodoStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTodoStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
