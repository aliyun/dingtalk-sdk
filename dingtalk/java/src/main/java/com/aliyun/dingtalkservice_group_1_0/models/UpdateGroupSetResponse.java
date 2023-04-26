// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupSetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateGroupSetResponseBody body;

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

    public UpdateGroupSetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateGroupSetResponse setBody(UpdateGroupSetResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateGroupSetResponseBody getBody() {
        return this.body;
    }

}
