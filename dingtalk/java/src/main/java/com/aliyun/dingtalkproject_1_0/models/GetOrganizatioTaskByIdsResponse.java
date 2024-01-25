// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizatioTaskByIdsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetOrganizatioTaskByIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOrganizatioTaskByIdsResponse setBody(GetOrganizatioTaskByIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrganizatioTaskByIdsResponseBody getBody() {
        return this.body;
    }

}
