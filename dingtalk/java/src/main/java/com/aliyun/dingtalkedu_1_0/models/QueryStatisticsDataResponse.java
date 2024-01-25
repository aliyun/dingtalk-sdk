// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryStatisticsDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryStatisticsDataResponseBody body;

    public static QueryStatisticsDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryStatisticsDataResponse self = new QueryStatisticsDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryStatisticsDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryStatisticsDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryStatisticsDataResponse setBody(QueryStatisticsDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryStatisticsDataResponseBody getBody() {
        return this.body;
    }

}
