// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class PushDingMessageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>10001</p>
     */
    @NameInMap("appId")
    public Long appId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>消息内容</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>CARD</p>
     */
    @NameInMap("messageType")
    public String messageType;

    /**
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
     */
    @NameInMap("messageUrl")
    public String messageUrl;

    /**
     * <strong>example:</strong>
     * <p><a href="http://pic.616pic.com/ys_b_img/00/27/71/Uu8E6C2Edn.jpg">http://pic.616pic.com/ys_b_img/00/27/71/Uu8E6C2Edn.jpg</a></p>
     */
    @NameInMap("pictureUrl")
    public String pictureUrl;

    /**
     * <strong>example:</strong>
     * <p>转跳链接</p>
     */
    @NameInMap("singleTitle")
    public String singleTitle;

    /**
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
     */
    @NameInMap("singleUrl")
    public String singleUrl;

    /**
     * <strong>example:</strong>
     * <p>消息title</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
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
