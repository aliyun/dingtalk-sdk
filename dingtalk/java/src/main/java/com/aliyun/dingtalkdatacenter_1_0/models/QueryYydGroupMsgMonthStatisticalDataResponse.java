// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydGroupMsgMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydGroupMsgMonthStatisticalDataResponseBody body;

    public static QueryYydGroupMsgMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydGroupMsgMonthStatisticalDataResponse self = new QueryYydGroupMsgMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydGroupMsgMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydGroupMsgMonthStatisticalDataResponse setBody(QueryYydGroupMsgMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydGroupMsgMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
