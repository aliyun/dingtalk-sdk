// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationPriorityListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetOrganizationPriorityListResponseBody body;

    public static GetOrganizationPriorityListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizationPriorityListResponse self = new GetOrganizationPriorityListResponse();
        return TeaModel.build(map, self);
    }

    public GetOrganizationPriorityListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrganizationPriorityListResponse setBody(GetOrganizationPriorityListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrganizationPriorityListResponseBody getBody() {
        return this.body;
    }

}
