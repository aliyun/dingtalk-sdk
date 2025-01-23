// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RemoveFromOrgSkillRepositoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RemoveFromOrgSkillRepositoryResponseBody body;

    public static RemoveFromOrgSkillRepositoryResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveFromOrgSkillRepositoryResponse self = new RemoveFromOrgSkillRepositoryResponse();
        return TeaModel.build(map, self);
    }

    public RemoveFromOrgSkillRepositoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveFromOrgSkillRepositoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveFromOrgSkillRepositoryResponse setBody(RemoveFromOrgSkillRepositoryResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveFromOrgSkillRepositoryResponseBody getBody() {
        return this.body;
    }

}
