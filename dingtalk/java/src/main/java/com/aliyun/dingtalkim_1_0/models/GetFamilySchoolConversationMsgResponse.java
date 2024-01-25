// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetFamilySchoolConversationMsgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetFamilySchoolConversationMsgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFamilySchoolConversationMsgResponse setBody(GetFamilySchoolConversationMsgResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFamilySchoolConversationMsgResponseBody getBody() {
        return this.body;
    }

}
