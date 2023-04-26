// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteRangeProtectionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteRangeProtectionResponseBody body;

    public static DeleteRangeProtectionResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteRangeProtectionResponse self = new DeleteRangeProtectionResponse();
        return TeaModel.build(map, self);
    }

    public DeleteRangeProtectionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteRangeProtectionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteRangeProtectionResponse setBody(DeleteRangeProtectionResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRangeProtectionResponseBody getBody() {
        return this.body;
    }

}
