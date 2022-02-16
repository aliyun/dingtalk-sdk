// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydGroupMsgWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydGroupMsgWeekStatisticalDataResponseBody body;

    public static QueryYydGroupMsgWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydGroupMsgWeekStatisticalDataResponse self = new QueryYydGroupMsgWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydGroupMsgWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydGroupMsgWeekStatisticalDataResponse setBody(QueryYydGroupMsgWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydGroupMsgWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
