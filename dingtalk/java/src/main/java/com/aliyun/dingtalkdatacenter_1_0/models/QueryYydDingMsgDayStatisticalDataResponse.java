// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydDingMsgDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydDingMsgDayStatisticalDataResponseBody body;

    public static QueryYydDingMsgDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydDingMsgDayStatisticalDataResponse self = new QueryYydDingMsgDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydDingMsgDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydDingMsgDayStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydDingMsgDayStatisticalDataResponse setBody(QueryYydDingMsgDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydDingMsgDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
