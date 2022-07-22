// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SaveFormRemarkRequest extends TeaModel {
    // 应用ID
    @NameInMap("appType")
    public String appType;

    // 将评论内容通过钉钉发给指定用户, 逗号分隔
    @NameInMap("atUserId")
    public String atUserId;

    // 评论内容
    @NameInMap("content")
    public String content;

    // 实例ID
    @NameInMap("formInstanceId")
    public String formInstanceId;

    // 语言
    @NameInMap("language")
    public String language;

    // 对评论进行回复
    @NameInMap("replyId")
    public Long replyId;

    // 应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // 评论人钉钉的userId
    @NameInMap("userId")
    public String userId;

    public static SaveFormRemarkRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveFormRemarkRequest self = new SaveFormRemarkRequest();
        return TeaModel.build(map, self);
    }

    public SaveFormRemarkRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public SaveFormRemarkRequest setAtUserId(String atUserId) {
        this.atUserId = atUserId;
        return this;
    }
    public String getAtUserId() {
        return this.atUserId;
    }

    public SaveFormRemarkRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SaveFormRemarkRequest setFormInstanceId(String formInstanceId) {
        this.formInstanceId = formInstanceId;
        return this;
    }
    public String getFormInstanceId() {
        return this.formInstanceId;
    }

    public SaveFormRemarkRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public SaveFormRemarkRequest setReplyId(Long replyId) {
        this.replyId = replyId;
        return this;
    }
    public Long getReplyId() {
        return this.replyId;
    }

    public SaveFormRemarkRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public SaveFormRemarkRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
