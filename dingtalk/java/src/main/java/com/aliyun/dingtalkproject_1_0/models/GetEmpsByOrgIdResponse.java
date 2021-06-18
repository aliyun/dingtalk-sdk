// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetEmpsByOrgIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetEmpsByOrgIdResponseBody body;

    public static GetEmpsByOrgIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetEmpsByOrgIdResponse self = new GetEmpsByOrgIdResponse();
        return TeaModel.build(map, self);
    }

    public GetEmpsByOrgIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetEmpsByOrgIdResponse setBody(GetEmpsByOrgIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetEmpsByOrgIdResponseBody getBody() {
        return this.body;
    }

}
