// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydAppDayStatisticalDataResponseBody body;

    public static QueryYydAppDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppDayStatisticalDataResponse self = new QueryYydAppDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydAppDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydAppDayStatisticalDataResponse setBody(QueryYydAppDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydAppDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
