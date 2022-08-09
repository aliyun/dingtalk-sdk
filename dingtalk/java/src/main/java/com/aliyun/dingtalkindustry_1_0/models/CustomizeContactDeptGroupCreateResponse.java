// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptGroupCreateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CustomizeContactDeptGroupCreateResponseBody body;

    public static CustomizeContactDeptGroupCreateResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptGroupCreateResponse self = new CustomizeContactDeptGroupCreateResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptGroupCreateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactDeptGroupCreateResponse setBody(CustomizeContactDeptGroupCreateResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactDeptGroupCreateResponseBody getBody() {
        return this.body;
    }

}
