// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydLogWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydLogWeekStatisticalDataResponseBody body;

    public static QueryYydLogWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydLogWeekStatisticalDataResponse self = new QueryYydLogWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydLogWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydLogWeekStatisticalDataResponse setBody(QueryYydLogWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydLogWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
