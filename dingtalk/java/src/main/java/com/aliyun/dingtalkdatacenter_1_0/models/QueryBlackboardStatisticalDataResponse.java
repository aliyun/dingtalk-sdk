// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryBlackboardStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryBlackboardStatisticalDataResponseBody body;

    public static QueryBlackboardStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBlackboardStatisticalDataResponse self = new QueryBlackboardStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryBlackboardStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBlackboardStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBlackboardStatisticalDataResponse setBody(QueryBlackboardStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBlackboardStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
