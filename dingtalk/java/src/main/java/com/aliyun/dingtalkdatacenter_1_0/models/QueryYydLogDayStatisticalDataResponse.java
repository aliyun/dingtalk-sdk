// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydLogDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydLogDayStatisticalDataResponseBody body;

    public static QueryYydLogDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydLogDayStatisticalDataResponse self = new QueryYydLogDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydLogDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydLogDayStatisticalDataResponse setBody(QueryYydLogDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydLogDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
