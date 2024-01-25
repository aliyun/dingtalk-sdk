// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentSubDeptsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListResidentSubDeptsResponseBody body;

    public static ListResidentSubDeptsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListResidentSubDeptsResponse self = new ListResidentSubDeptsResponse();
        return TeaModel.build(map, self);
    }

    public ListResidentSubDeptsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListResidentSubDeptsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListResidentSubDeptsResponse setBody(ListResidentSubDeptsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListResidentSubDeptsResponseBody getBody() {
        return this.body;
    }

}
