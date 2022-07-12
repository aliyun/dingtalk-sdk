// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class PushDingMessageRequest extends TeaModel {
    // 应用Id，默认是医疗的应用。
    @NameInMap("appId")
    public Long appId;

    // 消息内容，长度不超过500。
    @NameInMap("content")
    public String content;

    // 消息类型：CARD:卡片消息；LINK:链接消息；TEXT：文本消息；
    @NameInMap("messageType")
    public String messageType;

    // 链接消息时，消息文案下的URL。
    @NameInMap("messageUrl")
    public String messageUrl;

    // 链接消息时，右侧图片URL。
    @NameInMap("pictureUrl")
    public String pictureUrl;

    // 卡片消息时，消息下面action的标题，长度不超过20。
    @NameInMap("singleTitle")
    public String singleTitle;

    // 卡片消息时，消息下面action转跳URL，长度不超过500。
    @NameInMap("singleUrl")
    public String singleUrl;

    // 消息展示标题，长度不超过100。
    @NameInMap("title")
    public String title;

    // 组织下的staffId列表
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static PushDingMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        PushDingMessageRequest self = new PushDingMessageRequest();
        return TeaModel.build(map, self);
    }

    public PushDingMessageRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public PushDingMessageRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public PushDingMessageRequest setMessageType(String messageType) {
        this.messageType = messageType;
        return this;
    }
    public String getMessageType() {
        return this.messageType;
    }

    public PushDingMessageRequest setMessageUrl(String messageUrl) {
        this.messageUrl = messageUrl;
        return this;
    }
    public String getMessageUrl() {
        return this.messageUrl;
    }

    public PushDingMessageRequest setPictureUrl(String pictureUrl) {
        this.pictureUrl = pictureUrl;
        return this;
    }
    public String getPictureUrl() {
        return this.pictureUrl;
    }

    public PushDingMessageRequest setSingleTitle(String singleTitle) {
        this.singleTitle = singleTitle;
        return this;
    }
    public String getSingleTitle() {
        return this.singleTitle;
    }

    public PushDingMessageRequest setSingleUrl(String singleUrl) {
        this.singleUrl = singleUrl;
        return this;
    }
    public String getSingleUrl() {
        return this.singleUrl;
    }

    public PushDingMessageRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public PushDingMessageRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}