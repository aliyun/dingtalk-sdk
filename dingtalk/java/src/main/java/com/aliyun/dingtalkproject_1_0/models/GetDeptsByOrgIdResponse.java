// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetDeptsByOrgIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDeptsByOrgIdResponseBody body;

    public static GetDeptsByOrgIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDeptsByOrgIdResponse self = new GetDeptsByOrgIdResponse();
        return TeaModel.build(map, self);
    }

    public GetDeptsByOrgIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDeptsByOrgIdResponse setBody(GetDeptsByOrgIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDeptsByOrgIdResponseBody getBody() {
        return this.body;
    }

}
