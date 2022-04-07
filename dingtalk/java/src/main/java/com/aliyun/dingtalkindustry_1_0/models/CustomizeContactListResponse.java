// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CustomizeContactListResponseBody body;

    public static CustomizeContactListResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactListResponse self = new CustomizeContactListResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactListResponse setBody(CustomizeContactListResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactListResponseBody getBody() {
        return this.body;
    }

}
