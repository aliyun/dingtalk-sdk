// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementModifySpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ManagementModifySpaceResponseBody body;

    public static ManagementModifySpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        ManagementModifySpaceResponse self = new ManagementModifySpaceResponse();
        return TeaModel.build(map, self);
    }

    public ManagementModifySpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ManagementModifySpaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ManagementModifySpaceResponse setBody(ManagementModifySpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public ManagementModifySpaceResponseBody getBody() {
        return this.body;
    }

}
