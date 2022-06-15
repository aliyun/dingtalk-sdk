// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetOrganizationTaskResponseBody body;

    public static GetOrganizationTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizationTaskResponse self = new GetOrganizationTaskResponse();
        return TeaModel.build(map, self);
    }

    public GetOrganizationTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrganizationTaskResponse setBody(GetOrganizationTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrganizationTaskResponseBody getBody() {
        return this.body;
    }

}
