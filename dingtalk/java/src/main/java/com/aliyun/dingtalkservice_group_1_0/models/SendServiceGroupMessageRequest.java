// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendServiceGroupMessageRequest extends TeaModel {
    @NameInMap("atDingtalkIds")
    public java.util.List<String> atDingtalkIds;

    @NameInMap("atMobiles")
    public java.util.List<String> atMobiles;

    @NameInMap("atUnionIds")
    public java.util.List<String> atUnionIds;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("btnOrientation")
    public String btnOrientation;

    @NameInMap("btns")
    public java.util.List<SendServiceGroupMessageRequestBtns> btns;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>你有新的任务待审批</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("hasContentLinks")
    public Boolean hasContentLinks;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("isAtAll")
    public Boolean isAtAll;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>MARKDOWN</p>
     */
    @NameInMap("messageType")
    public String messageType;

    @NameInMap("receiverDingtalkIds")
    public java.util.List<String> receiverDingtalkIds;

    @NameInMap("receiverMobiles")
    public java.util.List<String> receiverMobiles;

    @NameInMap("receiverUnionIds")
    public java.util.List<String> receiverUnionIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxxx==</p>
     */
    @NameInMap("targetOpenConversationId")
    public String targetOpenConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>服务提醒</p>
     */
    @NameInMap("title")
    public String title;

    public static SendServiceGroupMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendServiceGroupMessageRequest self = new SendServiceGroupMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendServiceGroupMessageRequest setAtDingtalkIds(java.util.List<String> atDingtalkIds) {
        this.atDingtalkIds = atDingtalkIds;
        return this;
    }
    public java.util.List<String> getAtDingtalkIds() {
        return this.atDingtalkIds;
    }

    public SendServiceGroupMessageRequest setAtMobiles(java.util.List<String> atMobiles) {
        this.atMobiles = atMobiles;
        return this;
    }
    public java.util.List<String> getAtMobiles() {
        return this.atMobiles;
    }

    public SendServiceGroupMessageRequest setAtUnionIds(java.util.List<String> atUnionIds) {
        this.atUnionIds = atUnionIds;
        return this;
    }
    public java.util.List<String> getAtUnionIds() {
        return this.atUnionIds;
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

    public SendServiceGroupMessageRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SendServiceGroupMessageRequest setHasContentLinks(Boolean hasContentLinks) {
        this.hasContentLinks = hasContentLinks;
        return this;
    }
    public Boolean getHasContentLinks() {
        return this.hasContentLinks;
    }

    public SendServiceGroupMessageRequest setIsAtAll(Boolean isAtAll) {
        this.isAtAll = isAtAll;
        return this;
    }
    public Boolean getIsAtAll() {
        return this.isAtAll;
    }

    public SendServiceGroupMessageRequest setMessageType(String messageType) {
        this.messageType = messageType;
        return this;
    }
    public String getMessageType() {
        return this.messageType;
    }

    public SendServiceGroupMessageRequest setReceiverDingtalkIds(java.util.List<String> receiverDingtalkIds) {
        this.receiverDingtalkIds = receiverDingtalkIds;
        return this;
    }
    public java.util.List<String> getReceiverDingtalkIds() {
        return this.receiverDingtalkIds;
    }

    public SendServiceGroupMessageRequest setReceiverMobiles(java.util.List<String> receiverMobiles) {
        this.receiverMobiles = receiverMobiles;
        return this;
    }
    public java.util.List<String> getReceiverMobiles() {
        return this.receiverMobiles;
    }

    public SendServiceGroupMessageRequest setReceiverUnionIds(java.util.List<String> receiverUnionIds) {
        this.receiverUnionIds = receiverUnionIds;
        return this;
    }
    public java.util.List<String> getReceiverUnionIds() {
        return this.receiverUnionIds;
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

    public static class SendServiceGroupMessageRequestBtns extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="http://www.dingtalk.com">http://www.dingtalk.com</a></p>
         */
        @NameInMap("actionURL")
        public String actionURL;

        /**
         * <strong>example:</strong>
         * <p>测试按钮</p>
         */
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
