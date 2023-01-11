// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RenderBatchCallbackRequest extends TeaModel {
    /**
     * <p>appType</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>组织id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>文件大小</p>
     */
    @NameInMap("fileSize")
    public Long fileSize;

    /**
     * <p>language</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>名称空间</p>
     */
    @NameInMap("namespace")
    public String namespace;

    /**
     * <p>oss文件链接</p>
     */
    @NameInMap("ossUrl")
    public String ossUrl;

    /**
     * <p>流水号</p>
     */
    @NameInMap("sequenceId")
    public String sequenceId;

    /**
     * <p>源</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <p>状态</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>systemToken</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>时间区域</p>
     */
    @NameInMap("timeZone")
    public String timeZone;

    /**
     * <p>userId</p>
     */
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
