// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListPartnerRolesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListPartnerRolesResponse setBody(ListPartnerRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListPartnerRolesResponseBody getBody() {
        return this.body;
    }

}
