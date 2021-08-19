// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryEmployeeTypeStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryEmployeeTypeStatisticalDataResponseBody body;

    public static QueryEmployeeTypeStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryEmployeeTypeStatisticalDataResponse self = new QueryEmployeeTypeStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryEmployeeTypeStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryEmployeeTypeStatisticalDataResponse setBody(QueryEmployeeTypeStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryEmployeeTypeStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
