// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydTotalMonthStatisticalDataResponseBody body;

    public static QueryYydTotalMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalMonthStatisticalDataResponse self = new QueryYydTotalMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydTotalMonthStatisticalDataResponse setBody(QueryYydTotalMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydTotalMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
