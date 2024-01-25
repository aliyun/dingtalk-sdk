// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryActiveUserStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryActiveUserStatisticalDataResponseBody body;

    public static QueryActiveUserStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryActiveUserStatisticalDataResponse self = new QueryActiveUserStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryActiveUserStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryActiveUserStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryActiveUserStatisticalDataResponse setBody(QueryActiveUserStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryActiveUserStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
