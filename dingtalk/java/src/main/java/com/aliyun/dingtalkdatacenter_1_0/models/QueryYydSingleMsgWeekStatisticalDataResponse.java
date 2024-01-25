// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydSingleMsgWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydSingleMsgWeekStatisticalDataResponseBody body;

    public static QueryYydSingleMsgWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydSingleMsgWeekStatisticalDataResponse self = new QueryYydSingleMsgWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydSingleMsgWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydSingleMsgWeekStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydSingleMsgWeekStatisticalDataResponse setBody(QueryYydSingleMsgWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydSingleMsgWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
