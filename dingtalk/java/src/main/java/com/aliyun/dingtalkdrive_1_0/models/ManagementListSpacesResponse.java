// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementListSpacesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

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

    public ManagementListSpacesResponse setBody(ManagementListSpacesResponseBody body) {
        this.body = body;
        return this;
    }
    public ManagementListSpacesResponseBody getBody() {
        return this.body;
    }

}
