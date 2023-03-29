// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUpdateAuthInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DigitalStoreUpdateAuthInfoResponseBody body;

    public static DigitalStoreUpdateAuthInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreUpdateAuthInfoResponse self = new DigitalStoreUpdateAuthInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreUpdateAuthInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreUpdateAuthInfoResponse setBody(DigitalStoreUpdateAuthInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreUpdateAuthInfoResponseBody getBody() {
        return this.body;
    }

}
