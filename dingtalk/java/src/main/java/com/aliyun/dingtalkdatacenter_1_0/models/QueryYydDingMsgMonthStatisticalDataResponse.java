// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydDingMsgMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydDingMsgMonthStatisticalDataResponseBody body;

    public static QueryYydDingMsgMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydDingMsgMonthStatisticalDataResponse self = new QueryYydDingMsgMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydDingMsgMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydDingMsgMonthStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydDingMsgMonthStatisticalDataResponse setBody(QueryYydDingMsgMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydDingMsgMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
