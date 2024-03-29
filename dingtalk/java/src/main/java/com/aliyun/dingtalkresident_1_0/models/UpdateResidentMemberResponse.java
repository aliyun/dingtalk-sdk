// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateResidentMemberResponseBody body;

    public static UpdateResidentMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentMemberResponse self = new UpdateResidentMemberResponse();
        return TeaModel.build(map, self);
    }

    public UpdateResidentMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateResidentMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateResidentMemberResponse setBody(UpdateResidentMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateResidentMemberResponseBody getBody() {
        return this.body;
    }

}
