// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskNoteResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateOrganizationTaskNoteResponseBody body;

    public static UpdateOrganizationTaskNoteResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskNoteResponse self = new UpdateOrganizationTaskNoteResponse();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskNoteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateOrganizationTaskNoteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateOrganizationTaskNoteResponse setBody(UpdateOrganizationTaskNoteResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateOrganizationTaskNoteResponseBody getBody() {
        return this.body;
    }

}
