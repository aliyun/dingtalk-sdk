// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SaveTeamMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SaveTeamMembersResponseBody body;

    public static SaveTeamMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveTeamMembersResponse self = new SaveTeamMembersResponse();
        return TeaModel.build(map, self);
    }

    public SaveTeamMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveTeamMembersResponse setBody(SaveTeamMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveTeamMembersResponseBody getBody() {
        return this.body;
    }

}
