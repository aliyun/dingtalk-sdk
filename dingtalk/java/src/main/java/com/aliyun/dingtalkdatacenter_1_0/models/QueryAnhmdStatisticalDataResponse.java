// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryAnhmdStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryAnhmdStatisticalDataResponseBody body;

    public static QueryAnhmdStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAnhmdStatisticalDataResponse self = new QueryAnhmdStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryAnhmdStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAnhmdStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAnhmdStatisticalDataResponse setBody(QueryAnhmdStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAnhmdStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
