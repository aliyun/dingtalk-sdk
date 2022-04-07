// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptDeleteResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CustomizeContactDeptDeleteResponseBody body;

    public static CustomizeContactDeptDeleteResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptDeleteResponse self = new CustomizeContactDeptDeleteResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptDeleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactDeptDeleteResponse setBody(CustomizeContactDeptDeleteResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactDeptDeleteResponseBody getBody() {
        return this.body;
    }

}
