// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreRolesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DigitalStoreRolesResponseBody body;

    public static DigitalStoreRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreRolesResponse self = new DigitalStoreRolesResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreRolesResponse setBody(DigitalStoreRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreRolesResponseBody getBody() {
        return this.body;
    }

}
