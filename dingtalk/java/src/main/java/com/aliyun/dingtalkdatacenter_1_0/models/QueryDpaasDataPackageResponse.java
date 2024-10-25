// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDpaasDataPackageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDpaasDataPackageResponseBody body;

    public static QueryDpaasDataPackageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDpaasDataPackageResponse self = new QueryDpaasDataPackageResponse();
        return TeaModel.build(map, self);
    }

    public QueryDpaasDataPackageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDpaasDataPackageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDpaasDataPackageResponse setBody(QueryDpaasDataPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDpaasDataPackageResponseBody getBody() {
        return this.body;
    }

}
