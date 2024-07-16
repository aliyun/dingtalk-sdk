// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryTotalDataCountServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTotalDataCountServiceResponseBody body;

    public static QueryTotalDataCountServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTotalDataCountServiceResponse self = new QueryTotalDataCountServiceResponse();
        return TeaModel.build(map, self);
    }

    public QueryTotalDataCountServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTotalDataCountServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTotalDataCountServiceResponse setBody(QueryTotalDataCountServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTotalDataCountServiceResponseBody getBody() {
        return this.body;
    }

}
