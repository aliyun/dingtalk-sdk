// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeliverNoticeCardRequest extends TeaModel {
    @NameInMap("atUnionIds")
    public java.util.List<String> atUnionIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("btnActionStr")
    public java.util.Map<String, String> btnActionStr;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public String content;

    @NameInMap("detailMobileUrl")
    public String detailMobileUrl;

    @NameInMap("detailPcUrl")
    public String detailPcUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("lastMessageI18n")
    public java.util.Map<String, String> lastMessageI18n;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>receiver_id</p>
     */
    @NameInMap("receiverId")
    public String receiverId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user/chat</p>
     */
    @NameInMap("receiverType")
    public String receiverType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeliverNoticeCardRequest build(java.util.Map<String, ?> map) throws Exception {
        DeliverNoticeCardRequest self = new DeliverNoticeCardRequest();
        return TeaModel.build(map, self);
    }

    public DeliverNoticeCardRequest setAtUnionIds(java.util.List<String> atUnionIds) {
        this.atUnionIds = atUnionIds;
        return this;
    }
    public java.util.List<String> getAtUnionIds() {
        return this.atUnionIds;
    }

    public DeliverNoticeCardRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public DeliverNoticeCardRequest setBtnActionStr(java.util.Map<String, String> btnActionStr) {
        this.btnActionStr = btnActionStr;
        return this;
    }
    public java.util.Map<String, String> getBtnActionStr() {
        return this.btnActionStr;
    }

    public DeliverNoticeCardRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public DeliverNoticeCardRequest setDetailMobileUrl(String detailMobileUrl) {
        this.detailMobileUrl = detailMobileUrl;
        return this;
    }
    public String getDetailMobileUrl() {
        return this.detailMobileUrl;
    }

    public DeliverNoticeCardRequest setDetailPcUrl(String detailPcUrl) {
        this.detailPcUrl = detailPcUrl;
        return this;
    }
    public String getDetailPcUrl() {
        return this.detailPcUrl;
    }

    public DeliverNoticeCardRequest setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
        this.lastMessageI18n = lastMessageI18n;
        return this;
    }
    public java.util.Map<String, String> getLastMessageI18n() {
        return this.lastMessageI18n;
    }

    public DeliverNoticeCardRequest setReceiverId(String receiverId) {
        this.receiverId = receiverId;
        return this;
    }
    public String getReceiverId() {
        return this.receiverId;
    }

    public DeliverNoticeCardRequest setReceiverType(String receiverType) {
        this.receiverType = receiverType;
        return this;
    }
    public String getReceiverType() {
        return this.receiverType;
    }

    public DeliverNoticeCardRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
