// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreGroupInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DigitalStoreGroupInfoResponseBody body;

    public static DigitalStoreGroupInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreGroupInfoResponse self = new DigitalStoreGroupInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreGroupInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreGroupInfoResponse setBody(DigitalStoreGroupInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreGroupInfoResponseBody getBody() {
        return this.body;
    }

}
