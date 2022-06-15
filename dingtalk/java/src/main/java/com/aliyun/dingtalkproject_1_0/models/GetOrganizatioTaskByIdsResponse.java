// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizatioTaskByIdsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetOrganizatioTaskByIdsResponseBody body;

    public static GetOrganizatioTaskByIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizatioTaskByIdsResponse self = new GetOrganizatioTaskByIdsResponse();
        return TeaModel.build(map, self);
    }

    public GetOrganizatioTaskByIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrganizatioTaskByIdsResponse setBody(GetOrganizatioTaskByIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrganizatioTaskByIdsResponseBody getBody() {
        return this.body;
    }

}
