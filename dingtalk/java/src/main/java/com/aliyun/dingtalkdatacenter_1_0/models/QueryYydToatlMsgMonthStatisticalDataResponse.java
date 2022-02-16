// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydToatlMsgMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydToatlMsgMonthStatisticalDataResponseBody body;

    public static QueryYydToatlMsgMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydToatlMsgMonthStatisticalDataResponse self = new QueryYydToatlMsgMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydToatlMsgMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydToatlMsgMonthStatisticalDataResponse setBody(QueryYydToatlMsgMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydToatlMsgMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
