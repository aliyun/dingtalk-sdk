// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetOrganizationTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOrganizationTaskResponse setBody(GetOrganizationTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrganizationTaskResponseBody getBody() {
        return this.body;
    }

}
