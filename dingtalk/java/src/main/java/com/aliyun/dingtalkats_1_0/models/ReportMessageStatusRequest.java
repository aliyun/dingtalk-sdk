// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ReportMessageStatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <strong>example:</strong>
     * <p>corp-ABC-prd</p>
     */
    @NameInMap("channel")
    public String channel;

    /**
     * <strong>example:</strong>
     * <p>INVALID_USER</p>
     */
    @NameInMap("errorCode")
    public String errorCode;

    /**
     * <strong>example:</strong>
     * <p>无效用户</p>
     */
    @NameInMap("errorMsg")
    public String errorMsg;

    /**
     * <strong>example:</strong>
     * <p>594c5b30-57bd-4001-8903-4dc64cdc6739</p>
     */
    @NameInMap("messageId")
    public String messageId;

    /**
     * <strong>example:</strong>
     * <p>AppUid@Channel</p>
     */
    @NameInMap("receiverUserId")
    public String receiverUserId;

    /**
     * <strong>example:</strong>
     * <p>AppUid@Channel</p>
     */
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
