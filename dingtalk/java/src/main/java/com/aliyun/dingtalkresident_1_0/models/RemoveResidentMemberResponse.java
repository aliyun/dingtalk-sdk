// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class RemoveResidentMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RemoveResidentMemberResponseBody body;

    public static RemoveResidentMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveResidentMemberResponse self = new RemoveResidentMemberResponse();
        return TeaModel.build(map, self);
    }

    public RemoveResidentMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveResidentMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveResidentMemberResponse setBody(RemoveResidentMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveResidentMemberResponseBody getBody() {
        return this.body;
    }

}
