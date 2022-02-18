// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTodoDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydTodoDayStatisticalDataResponseBody body;

    public static QueryYydTodoDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTodoDayStatisticalDataResponse self = new QueryYydTodoDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydTodoDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydTodoDayStatisticalDataResponse setBody(QueryYydTodoDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydTodoDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}