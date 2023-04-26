// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ReportMessageStatusRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("channel")
    public String channel;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("messageId")
    public String messageId;

    @NameInMap("receiverUserId")
    public String receiverUserId;

    @NameInMap("senderUserId")
    public String senderUserId;

    public static ReportMessageStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        ReportMessageStatusRequest self = new ReportMessageStatusRequest();
        return TeaModel.build(map, self);
    }

    public ReportMessageStatusRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
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

    public ReportMessageStatusRequest setReceiverUserId(String receiverUserId) {
        this.receiverUserId = receiverUserId;
        return this;
    }
    public String getReceiverUserId() {
        return this.receiverUserId;
    }

    public ReportMessageStatusRequest setSenderUserId(String senderUserId) {
        this.senderUserId = senderUserId;
        return this;
    }
    public String getSenderUserId() {
        return this.senderUserId;
    }

}
