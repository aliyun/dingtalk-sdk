// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupSetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public Boolean body;

    public static UpdateGroupSetResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupSetResponse self = new UpdateGroupSetResponse();
        return TeaModel.build(map, self);
    }

    public UpdateGroupSetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateGroupSetResponse setBody(Boolean body) {
        this.body = body;
        return this;
    }
    public Boolean getBody() {
        return this.body;
    }

}