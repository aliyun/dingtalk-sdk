// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydToatlMsgDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydToatlMsgDayStatisticalDataResponseBody body;

    public static QueryYydToatlMsgDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydToatlMsgDayStatisticalDataResponse self = new QueryYydToatlMsgDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydToatlMsgDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydToatlMsgDayStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydToatlMsgDayStatisticalDataResponse setBody(QueryYydToatlMsgDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydToatlMsgDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
