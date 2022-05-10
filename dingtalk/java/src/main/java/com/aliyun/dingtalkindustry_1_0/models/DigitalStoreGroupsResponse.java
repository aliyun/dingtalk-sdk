// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreGroupsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DigitalStoreGroupsResponseBody body;

    public static DigitalStoreGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreGroupsResponse self = new DigitalStoreGroupsResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreGroupsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreGroupsResponse setBody(DigitalStoreGroupsResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreGroupsResponseBody getBody() {
        return this.body;
    }

}
