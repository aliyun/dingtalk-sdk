// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydSingleMsgMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydSingleMsgMonthStatisticalDataResponseBody body;

    public static QueryYydSingleMsgMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydSingleMsgMonthStatisticalDataResponse self = new QueryYydSingleMsgMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydSingleMsgMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydSingleMsgMonthStatisticalDataResponse setBody(QueryYydSingleMsgMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydSingleMsgMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}