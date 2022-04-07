// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptUpdateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CustomizeContactDeptUpdateResponseBody body;

    public static CustomizeContactDeptUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptUpdateResponse self = new CustomizeContactDeptUpdateResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactDeptUpdateResponse setBody(CustomizeContactDeptUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactDeptUpdateResponseBody getBody() {
        return this.body;
    }

}
