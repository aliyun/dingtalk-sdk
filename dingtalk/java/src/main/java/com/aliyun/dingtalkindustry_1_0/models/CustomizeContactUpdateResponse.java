// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactUpdateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CustomizeContactUpdateResponseBody body;

    public static CustomizeContactUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactUpdateResponse self = new CustomizeContactUpdateResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactUpdateResponse setBody(CustomizeContactUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactUpdateResponseBody getBody() {
        return this.body;
    }

}
