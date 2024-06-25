// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SaveFormRemarkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <strong>example:</strong>
     * <p>多个工号,用英文逗号分隔</p>
     */
    @NameInMap("atUserId")
    public String atUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>未知</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>33f6d221-17f8-42b7-836a-682b95a046c2</p>
     */
    @NameInMap("formInstanceId")
    public String formInstanceId;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <strong>example:</strong>
     * <p>12</p>
     */
    @NameInMap("replyId")
    public Long replyId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hexxxx</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>未知</p>
     */
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
