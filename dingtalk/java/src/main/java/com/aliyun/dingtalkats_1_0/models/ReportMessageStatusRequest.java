// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ReportMessageStatusRequest extends TeaModel {
    // 渠道标识。
    @NameInMap("channel")
    public String channel;

    // 错误码。
    @NameInMap("errorCode")
    public String errorCode;

    // 错误信息描述。
    @NameInMap("errorMsg")
    public String errorMsg;

    // 消息ID。
    @NameInMap("messageId")
    public String messageId;

    public static ReportMessageStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        ReportMessageStatusRequest self = new ReportMessageStatusRequest();
        return TeaModel.build(map, self);
    }

    public ReportMessageStatusRequest setChannel(String channel) {
        this.channel = channel;
        return this;
    }
    public String getChannel() {
        return this.channel;
    }

    public ReportMessageStatusRequest setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public ReportMessageStatusRequest setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public ReportMessageStatusRequest setMessageId(String messageId) {
        this.messageId = messageId;
        return this;
    }
    public String getMessageId() {
        return this.messageId;
    }

}
