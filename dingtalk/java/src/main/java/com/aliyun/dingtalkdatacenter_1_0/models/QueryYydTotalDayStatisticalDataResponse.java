// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydTotalDayStatisticalDataResponseBody body;

    public static QueryYydTotalDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalDayStatisticalDataResponse self = new QueryYydTotalDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydTotalDayStatisticalDataResponse setBody(QueryYydTotalDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydTotalDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}