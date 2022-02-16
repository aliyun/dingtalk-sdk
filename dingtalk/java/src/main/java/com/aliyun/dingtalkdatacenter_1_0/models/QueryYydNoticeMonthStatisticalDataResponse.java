// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydNoticeMonthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydNoticeMonthStatisticalDataResponseBody body;

    public static QueryYydNoticeMonthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydNoticeMonthStatisticalDataResponse self = new QueryYydNoticeMonthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydNoticeMonthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydNoticeMonthStatisticalDataResponse setBody(QueryYydNoticeMonthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydNoticeMonthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
