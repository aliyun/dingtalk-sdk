// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetFamilySchoolConversationMsgResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetFamilySchoolConversationMsgResponseBody body;

    public static GetFamilySchoolConversationMsgResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFamilySchoolConversationMsgResponse self = new GetFamilySchoolConversationMsgResponse();
        return TeaModel.build(map, self);
    }

    public GetFamilySchoolConversationMsgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFamilySchoolConversationMsgResponse setBody(GetFamilySchoolConversationMsgResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFamilySchoolConversationMsgResponseBody getBody() {
        return this.body;
    }

}
