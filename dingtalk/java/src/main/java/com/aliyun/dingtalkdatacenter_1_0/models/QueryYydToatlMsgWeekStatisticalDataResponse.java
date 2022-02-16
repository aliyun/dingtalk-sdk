// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydToatlMsgWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydToatlMsgWeekStatisticalDataResponseBody body;

    public static QueryYydToatlMsgWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydToatlMsgWeekStatisticalDataResponse self = new QueryYydToatlMsgWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydToatlMsgWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydToatlMsgWeekStatisticalDataResponse setBody(QueryYydToatlMsgWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydToatlMsgWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
