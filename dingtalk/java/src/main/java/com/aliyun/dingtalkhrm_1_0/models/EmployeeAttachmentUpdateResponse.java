// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class EmployeeAttachmentUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EmployeeAttachmentUpdateResponseBody body;

    public static EmployeeAttachmentUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        EmployeeAttachmentUpdateResponse self = new EmployeeAttachmentUpdateResponse();
        return TeaModel.build(map, self);
    }

    public EmployeeAttachmentUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EmployeeAttachmentUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EmployeeAttachmentUpdateResponse setBody(EmployeeAttachmentUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public EmployeeAttachmentUpdateResponseBody getBody() {
        return this.body;
    }

}
