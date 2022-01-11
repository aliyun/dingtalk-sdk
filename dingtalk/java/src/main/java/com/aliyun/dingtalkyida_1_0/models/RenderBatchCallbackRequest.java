// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RenderBatchCallbackRequest extends TeaModel {
    // appType
    @NameInMap("appType")
    public String appType;

    // 组织id
    @NameInMap("corpId")
    public String corpId;

    // 文件大小
    @NameInMap("fileSize")
    public Long fileSize;

    // language
    @NameInMap("language")
    public String language;

    // 名称空间
    @NameInMap("namespace")
    public String namespace;

    // oss文件链接
    @NameInMap("ossUrl")
    public String ossUrl;

    // 流水号
    @NameInMap("sequenceId")
    public String sequenceId;

    // 源
    @NameInMap("source")
    public String source;

    // 状态
    @NameInMap("status")
    public String status;

    // systemToken
    @NameInMap("systemToken")
    public String systemToken;

    // 时间区域
    @NameInMap("timeZone")
    public String timeZone;

    // userId
    @NameInMap("userId")
    public String userId;

    public static RenderBatchCallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        RenderBatchCallbackRequest self = new RenderBatchCallbackRequest();
        return TeaModel.build(map, self);
    }

    public RenderBatchCallbackRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public RenderBatchCallbackRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public RenderBatchCallbackRequest setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public RenderBatchCallbackRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public RenderBatchCallbackRequest setNamespace(String namespace) {
        this.namespace = namespace;
        return this;
    }
    public String getNamespace() {
        return this.namespace;
    }

    public RenderBatchCallbackRequest setOssUrl(String ossUrl) {
        this.ossUrl = ossUrl;
        return this;
    }
    public String getOssUrl() {
        return this.ossUrl;
    }

    public RenderBatchCallbackRequest setSequenceId(String sequenceId) {
        this.sequenceId = sequenceId;
        return this;
    }
    public String getSequenceId() {
        return this.sequenceId;
    }

    public RenderBatchCallbackRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public RenderBatchCallbackRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public RenderBatchCallbackRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public RenderBatchCallbackRequest setTimeZone(String timeZone) {
        this.timeZone = timeZone;
        return this;
    }
    public String getTimeZone() {
        return this.timeZone;
    }

    public RenderBatchCallbackRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
