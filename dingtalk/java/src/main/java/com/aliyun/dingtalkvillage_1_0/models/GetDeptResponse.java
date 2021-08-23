// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDeptResponseBody body;

    public static GetDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDeptResponse self = new GetDeptResponse();
        return TeaModel.build(map, self);
    }

    public GetDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDeptResponse setBody(GetDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDeptResponseBody getBody() {
        return this.body;
    }

}
