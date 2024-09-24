// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class EditSecurityConfigMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EditSecurityConfigMemberResponseBody body;

    public static EditSecurityConfigMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        EditSecurityConfigMemberResponse self = new EditSecurityConfigMemberResponse();
        return TeaModel.build(map, self);
    }

    public EditSecurityConfigMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditSecurityConfigMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditSecurityConfigMemberResponse setBody(EditSecurityConfigMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public EditSecurityConfigMemberResponseBody getBody() {
        return this.body;
    }

}
