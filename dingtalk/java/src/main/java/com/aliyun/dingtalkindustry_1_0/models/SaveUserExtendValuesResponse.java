// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SaveUserExtendValuesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SaveUserExtendValuesResponseBody body;

    public static SaveUserExtendValuesResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveUserExtendValuesResponse self = new SaveUserExtendValuesResponse();
        return TeaModel.build(map, self);
    }

    public SaveUserExtendValuesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveUserExtendValuesResponse setBody(SaveUserExtendValuesResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveUserExtendValuesResponseBody getBody() {
        return this.body;
    }

}
