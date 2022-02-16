// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydSingleMsgDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydSingleMsgDayStatisticalDataResponseBody body;

    public static QueryYydSingleMsgDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydSingleMsgDayStatisticalDataResponse self = new QueryYydSingleMsgDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydSingleMsgDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydSingleMsgDayStatisticalDataResponse setBody(QueryYydSingleMsgDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydSingleMsgDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
