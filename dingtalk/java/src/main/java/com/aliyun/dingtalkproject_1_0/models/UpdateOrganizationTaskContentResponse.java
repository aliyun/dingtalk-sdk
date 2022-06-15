// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskContentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateOrganizationTaskContentResponse setBody(UpdateOrganizationTaskContentResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateOrganizationTaskContentResponseBody getBody() {
        return this.body;
    }

}
