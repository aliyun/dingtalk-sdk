// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryHealthStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryHealthStatisticalDataResponseBody body;

    public static QueryHealthStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryHealthStatisticalDataResponse self = new QueryHealthStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryHealthStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryHealthStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryHealthStatisticalDataResponse setBody(QueryHealthStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryHealthStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
