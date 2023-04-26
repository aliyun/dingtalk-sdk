// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementListSpacesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ManagementListSpacesResponseBody body;

    public static ManagementListSpacesResponse build(java.util.Map<String, ?> map) throws Exception {
        ManagementListSpacesResponse self = new ManagementListSpacesResponse();
        return TeaModel.build(map, self);
    }

    public ManagementListSpacesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ManagementListSpacesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ManagementListSpacesResponse setBody(ManagementListSpacesResponseBody body) {
        this.body = body;
        return this;
    }
    public ManagementListSpacesResponseBody getBody() {
        return this.body;
    }

}
