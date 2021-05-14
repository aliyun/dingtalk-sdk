// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushCustomerGroupMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PushCustomerGroupMessageResponseBody body;

    public static PushCustomerGroupMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        PushCustomerGroupMessageResponse self = new PushCustomerGroupMessageResponse();
        return TeaModel.build(map, self);
    }

    public PushCustomerGroupMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushCustomerGroupMessageResponse setBody(PushCustomerGroupMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public PushCustomerGroupMessageResponseBody getBody() {
        return this.body;
    }

}
