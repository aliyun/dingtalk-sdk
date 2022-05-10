// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreContactInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DigitalStoreContactInfoResponseBody body;

    public static DigitalStoreContactInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreContactInfoResponse self = new DigitalStoreContactInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreContactInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreContactInfoResponse setBody(DigitalStoreContactInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreContactInfoResponseBody getBody() {
        return this.body;
    }

}
