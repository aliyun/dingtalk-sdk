// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListCrmPersonalCustomersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListCrmPersonalCustomersResponseBody body;

    public static ListCrmPersonalCustomersResponse build(java.util.Map<String, ?> map) throws Exception {
        ListCrmPersonalCustomersResponse self = new ListCrmPersonalCustomersResponse();
        return TeaModel.build(map, self);
    }

    public ListCrmPersonalCustomersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListCrmPersonalCustomersResponse setBody(ListCrmPersonalCustomersResponseBody body) {
        this.body = body;
        return this;
    }
    public ListCrmPersonalCustomersResponseBody getBody() {
        return this.body;
    }

}
