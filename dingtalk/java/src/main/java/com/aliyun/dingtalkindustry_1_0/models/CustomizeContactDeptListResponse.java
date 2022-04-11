// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CustomizeContactDeptListResponseBody body;

    public static CustomizeContactDeptListResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptListResponse self = new CustomizeContactDeptListResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactDeptListResponse setBody(CustomizeContactDeptListResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactDeptListResponseBody getBody() {
        return this.body;
    }

}