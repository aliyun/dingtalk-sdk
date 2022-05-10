// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreStoreInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DigitalStoreStoreInfoResponseBody body;

    public static DigitalStoreStoreInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreStoreInfoResponse self = new DigitalStoreStoreInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreStoreInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreStoreInfoResponse setBody(DigitalStoreStoreInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreStoreInfoResponseBody getBody() {
        return this.body;
    }

}
