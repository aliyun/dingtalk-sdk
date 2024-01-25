// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskContentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateOrganizationTaskContentResponseBody body;

    public static UpdateOrganizationTaskContentResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskContentResponse self = new UpdateOrganizationTaskContentResponse();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskContentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateOrganizationTaskContentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateOrganizationTaskContentResponse setBody(UpdateOrganizationTaskContentResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateOrganizationTaskContentResponseBody getBody() {
        return this.body;
    }

}
