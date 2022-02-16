// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydAppWeekStatisticalDataResponseBody body;

    public static QueryYydAppWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppWeekStatisticalDataResponse self = new QueryYydAppWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydAppWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydAppWeekStatisticalDataResponse setBody(QueryYydAppWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydAppWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
