// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydActiveMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydActiveMonthStatisticalDataResponseBody body;

    public static QueryYydActiveMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydActiveMonthStatisticalDataResponse self = new QueryYydActiveMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydActiveMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydActiveMonthStatisticalDataResponse setBody(QueryYydActiveMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydActiveMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
