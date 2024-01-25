// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDocumentStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDocumentStatisticalDataResponseBody body;

    public static QueryDocumentStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDocumentStatisticalDataResponse self = new QueryDocumentStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryDocumentStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDocumentStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDocumentStatisticalDataResponse setBody(QueryDocumentStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDocumentStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
