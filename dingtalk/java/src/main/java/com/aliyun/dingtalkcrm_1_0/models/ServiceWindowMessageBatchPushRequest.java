// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ServiceWindowMessageBatchPushRequest extends TeaModel {
    @NameInMap("detail")
    public ServiceWindowMessageBatchPushRequestDetail detail;

    @NameInMap("bizId")
    public String bizId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static ServiceWindowMessageBatchPushRequest build(java.util.Map<String, ?> map) throws Exception {
        ServiceWindowMessageBatchPushRequest self = new ServiceWindowMessageBatchPushRequest();
        return TeaModel.build(map, self);
    }

    public ServiceWindowMessageBatchPushRequest setDetail(ServiceWindowMessageBatchPushRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public ServiceWindowMessageBatchPushRequestDetail getDetail() {
        return this.detail;
    }

    public ServiceWindowMessageBatchPushRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ServiceWindowMessageBatchPushRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public ServiceWindowMessageBatchPushRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public ServiceWindowMessageBatchPushRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public ServiceWindowMessageBatchPushRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public static class ServiceWindowMessageBatchPushRequestDetailMessageBodyText extends TeaModel {
        @NameInMap("content")
        public String content;

        public static ServiceWindowMessageBatchPushRequestDetailMessageBodyText build(java.util.Map<String, ?> map) throws Exception {
            ServiceWindowMessageBatchPushRequestDetailMessageBodyText self = new ServiceWindowMessageBatchPushRequestDetailMessageBodyText();
            return TeaModel.build(map, self);
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyText setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

    public static class ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown extends TeaModel {
        @NameInMap("title")
        public String title;

        @NameInMap("text")
        public String text;

        public static ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown build(java.util.Map<String, ?> map) throws Exception {
            ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown self = new ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown();
            return TeaModel.build(map, self);
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class ServiceWindowMessageBatchPushRequestDetailMessageBodyLink extends TeaModel {
        @NameInMap("picUrl")
        public String picUrl;

        @NameInMap("messageUrl")
        public String messageUrl;

        @NameInMap("title")
        public String title;

        @NameInMap("text")
        public String text;

        public static ServiceWindowMessageBatchPushRequestDetailMessageBodyLink build(java.util.Map<String, ?> map) throws Exception {
            ServiceWindowMessageBatchPushRequestDetailMessageBodyLink self = new ServiceWindowMessageBatchPushRequestDetailMessageBodyLink();
            return TeaModel.build(map, self);
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyLink setPicUrl(String picUrl) {
            this.picUrl = picUrl;
            return this;
        }
        public String getPicUrl() {
            return this.picUrl;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyLink setMessageUrl(String messageUrl) {
            this.messageUrl = messageUrl;
            return this;
        }
        public String getMessageUrl() {
            return this.messageUrl;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyLink setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyLink setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList extends TeaModel {
        @NameInMap("title")
        public String title;

        @NameInMap("actionUrl")
        public String actionUrl;

        public static ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList build(java.util.Map<String, ?> map) throws Exception {
            ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList self = new ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList();
            return TeaModel.build(map, self);
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

    }

    public static class ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard extends TeaModel {
        @NameInMap("buttonOrientation")
        public String buttonOrientation;

        @NameInMap("singleUrl")
        public String singleUrl;

        @NameInMap("singleTitle")
        public String singleTitle;

        @NameInMap("markdown")
        public String markdown;

        @NameInMap("title")
        public String title;

        @NameInMap("buttonList")
        public java.util.List<ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList> buttonList;

        public static ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard build(java.util.Map<String, ?> map) throws Exception {
            ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard self = new ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard();
            return TeaModel.build(map, self);
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard setButtonOrientation(String buttonOrientation) {
            this.buttonOrientation = buttonOrientation;
            return this;
        }
        public String getButtonOrientation() {
            return this.buttonOrientation;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard setSingleUrl(String singleUrl) {
            this.singleUrl = singleUrl;
            return this;
        }
        public String getSingleUrl() {
            return this.singleUrl;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard setSingleTitle(String singleTitle) {
            this.singleTitle = singleTitle;
            return this;
        }
        public String getSingleTitle() {
            return this.singleTitle;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard setMarkdown(String markdown) {
            this.markdown = markdown;
            return this;
        }
        public String getMarkdown() {
            return this.markdown;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard setButtonList(java.util.List<ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList> buttonList) {
            this.buttonList = buttonList;
            return this;
        }
        public java.util.List<ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList> getButtonList() {
            return this.buttonList;
        }

    }

    public static class ServiceWindowMessageBatchPushRequestDetailMessageBody extends TeaModel {
        @NameInMap("text")
        public ServiceWindowMessageBatchPushRequestDetailMessageBodyText text;

        @NameInMap("markdown")
        public ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown markdown;

        @NameInMap("link")
        public ServiceWindowMessageBatchPushRequestDetailMessageBodyLink link;

        @NameInMap("actionCard")
        public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard actionCard;

        public static ServiceWindowMessageBatchPushRequestDetailMessageBody build(java.util.Map<String, ?> map) throws Exception {
            ServiceWindowMessageBatchPushRequestDetailMessageBody self = new ServiceWindowMessageBatchPushRequestDetailMessageBody();
            return TeaModel.build(map, self);
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBody setText(ServiceWindowMessageBatchPushRequestDetailMessageBodyText text) {
            this.text = text;
            return this;
        }
        public ServiceWindowMessageBatchPushRequestDetailMessageBodyText getText() {
            return this.text;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBody setMarkdown(ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown markdown) {
            this.markdown = markdown;
            return this;
        }
        public ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown getMarkdown() {
            return this.markdown;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBody setLink(ServiceWindowMessageBatchPushRequestDetailMessageBodyLink link) {
            this.link = link;
            return this;
        }
        public ServiceWindowMessageBatchPushRequestDetailMessageBodyLink getLink() {
            return this.link;
        }

        public ServiceWindowMessageBatchPushRequestDetailMessageBody setActionCard(ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard actionCard) {
            this.actionCard = actionCard;
            return this;
        }
        public ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard getActionCard() {
            return this.actionCard;
        }

    }

    public static class ServiceWindowMessageBatchPushRequestDetail extends TeaModel {
        @NameInMap("msgType")
        public String msgType;

        @NameInMap("uuid")
        public String uuid;

        @NameInMap("bizRequestId")
        public String bizRequestId;

        @NameInMap("userIdList")
        public java.util.List<String> userIdList;

        @NameInMap("messageBody")
        public ServiceWindowMessageBatchPushRequestDetailMessageBody messageBody;

        @NameInMap("sendToAll")
        public Boolean sendToAll;

        public static ServiceWindowMessageBatchPushRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            ServiceWindowMessageBatchPushRequestDetail self = new ServiceWindowMessageBatchPushRequestDetail();
            return TeaModel.build(map, self);
        }

        public ServiceWindowMessageBatchPushRequestDetail setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public ServiceWindowMessageBatchPushRequestDetail setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public ServiceWindowMessageBatchPushRequestDetail setBizRequestId(String bizRequestId) {
            this.bizRequestId = bizRequestId;
            return this;
        }
        public String getBizRequestId() {
            return this.bizRequestId;
        }

        public ServiceWindowMessageBatchPushRequestDetail setUserIdList(java.util.List<String> userIdList) {
            this.userIdList = userIdList;
            return this;
        }
        public java.util.List<String> getUserIdList() {
            return this.userIdList;
        }

        public ServiceWindowMessageBatchPushRequestDetail setMessageBody(ServiceWindowMessageBatchPushRequestDetailMessageBody messageBody) {
            this.messageBody = messageBody;
            return this;
        }
        public ServiceWindowMessageBatchPushRequestDetailMessageBody getMessageBody() {
            return this.messageBody;
        }

        public ServiceWindowMessageBatchPushRequestDetail setSendToAll(Boolean sendToAll) {
            this.sendToAll = sendToAll;
            return this;
        }
        public Boolean getSendToAll() {
            return this.sendToAll;
        }

    }

}
