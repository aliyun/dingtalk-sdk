// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUsersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DigitalStoreUsersResponseBody body;

    public static DigitalStoreUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreUsersResponse self = new DigitalStoreUsersResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreUsersResponse setBody(DigitalStoreUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreUsersResponseBody getBody() {
        return this.body;
    }

}
