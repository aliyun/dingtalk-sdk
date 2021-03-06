// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendServiceGroupMessageRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    // 开放群ID
    @NameInMap("targetOpenConversationId")
    public String targetOpenConversationId;

    // 标题
    @NameInMap("title")
    public String title;

    // 内容
    @NameInMap("content")
    public String content;

    // 是否 at所有人
    @NameInMap("isAtAll")
    public Boolean isAtAll;

    // at 手机号
    @NameInMap("atMobiles")
    public java.util.List<String> atMobiles;

    // at dingtalkId
    @NameInMap("atDingtalkIds")
    public java.util.List<String> atDingtalkIds;

    // at unionIds
    @NameInMap("atUnionIds")
    public java.util.List<String> atUnionIds;

    // 手机号接收者
    @NameInMap("receiverMobiles")
    public java.util.List<String> receiverMobiles;

    // dingtalkId接收者
    @NameInMap("receiverDingtalkIds")
    public java.util.List<String> receiverDingtalkIds;

    // unionId接收者
    @NameInMap("receiverUnionIds")
    public java.util.List<String> receiverUnionIds;

    // 消息类型：MARKDOWN，ACTIONCARD
    @NameInMap("messageType")
    public String messageType;

    // 排列方式：0-按钮竖直排列，1-按钮横向排列
    @NameInMap("btnOrientation")
    public String btnOrientation;

    // actionCard按钮
    @NameInMap("btns")
    public java.util.List<SendServiceGroupMessageRequestBtns> btns;

    public static SendServiceGroupMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendServiceGroupMessageRequest self = new SendServiceGroupMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendServiceGroupMessageRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public SendServiceGroupMessageRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public SendServiceGroupMessageRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public SendServiceGroupMessageRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public SendServiceGroupMessageRequest setTargetOpenConversationId(String targetOpenConversationId) {
        this.targetOpenConversationId = targetOpenConversationId;
        return this;
    }
    public String getTargetOpenConversationId() {
        return this.targetOpenConversationId;
    }

    public SendServiceGroupMessageRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SendServiceGroupMessageRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SendServiceGroupMessageRequest setIsAtAll(Boolean isAtAll) {
        this.isAtAll = isAtAll;
        return this;
    }
    public Boolean getIsAtAll() {
        return this.isAtAll;
    }

    public SendServiceGroupMessageRequest setAtMobiles(java.util.List<String> atMobiles) {
        this.atMobiles = atMobiles;
        return this;
    }
    public java.util.List<String> getAtMobiles() {
        return this.atMobiles;
    }

    public SendServiceGroupMessageRequest setAtDingtalkIds(java.util.List<String> atDingtalkIds) {
        this.atDingtalkIds = atDingtalkIds;
        return this;
    }
    public java.util.List<String> getAtDingtalkIds() {
        return this.atDingtalkIds;
    }

    public SendServiceGroupMessageRequest setAtUnionIds(java.util.List<String> atUnionIds) {
        this.atUnionIds = atUnionIds;
        return this;
    }
    public java.util.List<String> getAtUnionIds() {
        return this.atUnionIds;
    }

    public SendServiceGroupMessageRequest setReceiverMobiles(java.util.List<String> receiverMobiles) {
        this.receiverMobiles = receiverMobiles;
        return this;
    }
    public java.util.List<String> getReceiverMobiles() {
        return this.receiverMobiles;
    }

    public SendServiceGroupMessageRequest setReceiverDingtalkIds(java.util.List<String> receiverDingtalkIds) {
        this.receiverDingtalkIds = receiverDingtalkIds;
        return this;
    }
    public java.util.List<String> getReceiverDingtalkIds() {
        return this.receiverDingtalkIds;
    }

    public SendServiceGroupMessageRequest setReceiverUnionIds(java.util.List<String> receiverUnionIds) {
        this.receiverUnionIds = receiverUnionIds;
        return this;
    }
    public java.util.List<String> getReceiverUnionIds() {
        return this.receiverUnionIds;
    }

    public SendServiceGroupMessageRequest setMessageType(String messageType) {
        this.messageType = messageType;
        return this;
    }
    public String getMessageType() {
        return this.messageType;
    }

    public SendServiceGroupMessageRequest setBtnOrientation(String btnOrientation) {
        this.btnOrientation = btnOrientation;
        return this;
    }
    public String getBtnOrientation() {
        return this.btnOrientation;
    }

    public SendServiceGroupMessageRequest setBtns(java.util.List<SendServiceGroupMessageRequestBtns> btns) {
        this.btns = btns;
        return this;
    }
    public java.util.List<SendServiceGroupMessageRequestBtns> getBtns() {
        return this.btns;
    }

    public static class SendServiceGroupMessageRequestBtns extends TeaModel {
        // 跳转地址
        @NameInMap("actionURL")
        public String actionURL;

        // 按钮名称
        @NameInMap("title")
        public String title;

        public static SendServiceGroupMessageRequestBtns build(java.util.Map<String, ?> map) throws Exception {
            SendServiceGroupMessageRequestBtns self = new SendServiceGroupMessageRequestBtns();
            return TeaModel.build(map, self);
        }

        public SendServiceGroupMessageRequestBtns setActionURL(String actionURL) {
            this.actionURL = actionURL;
            return this;
        }
        public String getActionURL() {
            return this.actionURL;
        }

        public SendServiceGroupMessageRequestBtns setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
