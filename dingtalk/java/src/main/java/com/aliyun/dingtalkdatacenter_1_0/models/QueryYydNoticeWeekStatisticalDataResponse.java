// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydNoticeWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryYydNoticeWeekStatisticalDataResponseBody body;

    public static QueryYydNoticeWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydNoticeWeekStatisticalDataResponse self = new QueryYydNoticeWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydNoticeWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydNoticeWeekStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydNoticeWeekStatisticalDataResponse setBody(QueryYydNoticeWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydNoticeWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
