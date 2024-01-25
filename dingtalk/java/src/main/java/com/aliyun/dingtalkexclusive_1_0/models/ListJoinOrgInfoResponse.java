// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListJoinOrgInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListJoinOrgInfoResponseBody body;

    public static ListJoinOrgInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        ListJoinOrgInfoResponse self = new ListJoinOrgInfoResponse();
        return TeaModel.build(map, self);
    }

    public ListJoinOrgInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListJoinOrgInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListJoinOrgInfoResponse setBody(ListJoinOrgInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public ListJoinOrgInfoResponseBody getBody() {
        return this.body;
    }

}
