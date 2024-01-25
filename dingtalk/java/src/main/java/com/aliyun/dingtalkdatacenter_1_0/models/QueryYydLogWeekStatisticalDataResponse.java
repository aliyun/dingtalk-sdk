// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydLogWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public QueryYydLogWeekStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryYydLogWeekStatisticalDataResponse setBody(QueryYydLogWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydLogWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
