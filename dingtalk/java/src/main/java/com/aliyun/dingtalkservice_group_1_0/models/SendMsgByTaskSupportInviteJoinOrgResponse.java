// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendMsgByTaskSupportInviteJoinOrgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendMsgByTaskSupportInviteJoinOrgResponseBody body;

    public static SendMsgByTaskSupportInviteJoinOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        SendMsgByTaskSupportInviteJoinOrgResponse self = new SendMsgByTaskSupportInviteJoinOrgResponse();
        return TeaModel.build(map, self);
    }

    public SendMsgByTaskSupportInviteJoinOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendMsgByTaskSupportInviteJoinOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendMsgByTaskSupportInviteJoinOrgResponse setBody(SendMsgByTaskSupportInviteJoinOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public SendMsgByTaskSupportInviteJoinOrgResponseBody getBody() {
        return this.body;
    }

}
