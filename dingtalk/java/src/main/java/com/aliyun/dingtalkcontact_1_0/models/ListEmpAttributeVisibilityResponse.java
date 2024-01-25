// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListEmpAttributeVisibilityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListEmpAttributeVisibilityResponseBody body;

    public static ListEmpAttributeVisibilityResponse build(java.util.Map<String, ?> map) throws Exception {
        ListEmpAttributeVisibilityResponse self = new ListEmpAttributeVisibilityResponse();
        return TeaModel.build(map, self);
    }

    public ListEmpAttributeVisibilityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListEmpAttributeVisibilityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListEmpAttributeVisibilityResponse setBody(ListEmpAttributeVisibilityResponseBody body) {
        this.body = body;
        return this;
    }
    public ListEmpAttributeVisibilityResponseBody getBody() {
        return this.body;
    }

}
