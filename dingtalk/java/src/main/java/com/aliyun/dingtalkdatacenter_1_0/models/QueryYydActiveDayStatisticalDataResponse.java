// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydActiveDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydActiveDayStatisticalDataResponseBody body;

    public static QueryYydActiveDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydActiveDayStatisticalDataResponse self = new QueryYydActiveDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydActiveDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydActiveDayStatisticalDataResponse setBody(QueryYydActiveDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydActiveDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
