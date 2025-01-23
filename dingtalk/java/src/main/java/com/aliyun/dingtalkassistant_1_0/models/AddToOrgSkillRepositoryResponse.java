// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AddToOrgSkillRepositoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddToOrgSkillRepositoryResponseBody body;

    public static AddToOrgSkillRepositoryResponse build(java.util.Map<String, ?> map) throws Exception {
        AddToOrgSkillRepositoryResponse self = new AddToOrgSkillRepositoryResponse();
        return TeaModel.build(map, self);
    }

    public AddToOrgSkillRepositoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddToOrgSkillRepositoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddToOrgSkillRepositoryResponse setBody(AddToOrgSkillRepositoryResponseBody body) {
        this.body = body;
        return this;
    }
    public AddToOrgSkillRepositoryResponseBody getBody() {
        return this.body;
    }

}
