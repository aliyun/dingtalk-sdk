// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListEmpAttributeVisibilityResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListEmpAttributeVisibilityResponse setBody(ListEmpAttributeVisibilityResponseBody body) {
        this.body = body;
        return this;
    }
    public ListEmpAttributeVisibilityResponseBody getBody() {
        return this.body;
    }

}
