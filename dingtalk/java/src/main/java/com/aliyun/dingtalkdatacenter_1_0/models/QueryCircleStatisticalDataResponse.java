// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCircleStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCircleStatisticalDataResponseBody body;

    public static QueryCircleStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCircleStatisticalDataResponse self = new QueryCircleStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryCircleStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCircleStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCircleStatisticalDataResponse setBody(QueryCircleStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCircleStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
