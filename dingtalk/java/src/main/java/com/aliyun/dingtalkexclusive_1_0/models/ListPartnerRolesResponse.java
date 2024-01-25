// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListPartnerRolesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListPartnerRolesResponseBody body;

    public static ListPartnerRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListPartnerRolesResponse self = new ListPartnerRolesResponse();
        return TeaModel.build(map, self);
    }

    public ListPartnerRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListPartnerRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListPartnerRolesResponse setBody(ListPartnerRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListPartnerRolesResponseBody getBody() {
        return this.body;
    }

}
