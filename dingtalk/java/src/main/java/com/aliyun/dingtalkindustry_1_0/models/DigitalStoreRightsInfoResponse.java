// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreRightsInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DigitalStoreRightsInfoResponseBody body;

    public static DigitalStoreRightsInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreRightsInfoResponse self = new DigitalStoreRightsInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreRightsInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreRightsInfoResponse setBody(DigitalStoreRightsInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreRightsInfoResponseBody getBody() {
        return this.body;
    }

}
