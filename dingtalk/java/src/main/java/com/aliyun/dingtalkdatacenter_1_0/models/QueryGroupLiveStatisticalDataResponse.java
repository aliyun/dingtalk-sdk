// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupLiveStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryGroupLiveStatisticalDataResponseBody body;

    public static QueryGroupLiveStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupLiveStatisticalDataResponse self = new QueryGroupLiveStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupLiveStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupLiveStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupLiveStatisticalDataResponse setBody(QueryGroupLiveStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupLiveStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
