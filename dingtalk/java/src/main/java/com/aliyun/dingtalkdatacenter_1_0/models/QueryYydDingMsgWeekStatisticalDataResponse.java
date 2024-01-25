// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydDingMsgWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydDingMsgWeekStatisticalDataResponseBody body;

    public static QueryYydDingMsgWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydDingMsgWeekStatisticalDataResponse self = new QueryYydDingMsgWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydDingMsgWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydDingMsgWeekStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydDingMsgWeekStatisticalDataResponse setBody(QueryYydDingMsgWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydDingMsgWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
