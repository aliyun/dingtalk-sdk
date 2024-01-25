// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerTaskUserDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCustomerTaskUserDetailResponseBody body;

    public static QueryCustomerTaskUserDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerTaskUserDetailResponse self = new QueryCustomerTaskUserDetailResponse();
        return TeaModel.build(map, self);
    }

    public QueryCustomerTaskUserDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCustomerTaskUserDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCustomerTaskUserDetailResponse setBody(QueryCustomerTaskUserDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCustomerTaskUserDetailResponseBody getBody() {
        return this.body;
    }

}
