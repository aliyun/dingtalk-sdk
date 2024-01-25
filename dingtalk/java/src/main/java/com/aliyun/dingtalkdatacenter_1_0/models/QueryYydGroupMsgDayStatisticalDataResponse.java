// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydGroupMsgDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydGroupMsgDayStatisticalDataResponseBody body;

    public static QueryYydGroupMsgDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydGroupMsgDayStatisticalDataResponse self = new QueryYydGroupMsgDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydGroupMsgDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydGroupMsgDayStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydGroupMsgDayStatisticalDataResponse setBody(QueryYydGroupMsgDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydGroupMsgDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
