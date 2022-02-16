// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydSingleMsgWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryYydSingleMsgWeekStatisticalDataResponse setBody(QueryYydSingleMsgWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydSingleMsgWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
