// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDingReciveStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDingReciveStatisticalDataResponseBody body;

    public static QueryDingReciveStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDingReciveStatisticalDataResponse self = new QueryDingReciveStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryDingReciveStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDingReciveStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDingReciveStatisticalDataResponse setBody(QueryDingReciveStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDingReciveStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
