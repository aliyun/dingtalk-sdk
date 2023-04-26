// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryMailStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryMailStatisticalDataResponseBody body;

    public static QueryMailStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMailStatisticalDataResponse self = new QueryMailStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryMailStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMailStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMailStatisticalDataResponse setBody(QueryMailStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMailStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
