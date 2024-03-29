// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCheckinStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCheckinStatisticalDataResponseBody body;

    public static QueryCheckinStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCheckinStatisticalDataResponse self = new QueryCheckinStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryCheckinStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCheckinStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCheckinStatisticalDataResponse setBody(QueryCheckinStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCheckinStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
