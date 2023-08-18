// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class MapValue extends TeaModel {
    @NameInMap("templateId")
    public String templateId;

    @NameInMap("title")
    public String title;

    @NameInMap("type")
    public Integer type;

    @NameInMap("coverDownloadUrl")
    public String coverDownloadUrl;

    @NameInMap("description")
    public String description;

    @NameInMap("authorName")
    public String authorName;

    @NameInMap("createTime")
    public String createTime;

    @NameInMap("modifiedTime")
    public String modifiedTime;

    @NameInMap("workspaceId")
    public String workspaceId;

    @NameInMap("workspaceName")
    public String workspaceName;

    @NameInMap("usedCount")
    public Long usedCount;

    @NameInMap("belong")
    public String belong;

    @NameInMap("contentDownloadUrl")
    public String contentDownloadUrl;

    public static MapValue build(java.util.Map<String, ?> map) throws Exception {
        MapValue self = new MapValue();
        return TeaModel.build(map, self);
    }

    public MapValue setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public MapValue setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public MapValue setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

    public MapValue setCoverDownloadUrl(String coverDownloadUrl) {
        this.coverDownloadUrl = coverDownloadUrl;
        return this;
    }
    public String getCoverDownloadUrl() {
        return this.coverDownloadUrl;
    }

    public MapValue setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public MapValue setAuthorName(String authorName) {
        this.authorName = authorName;
        return this;
    }
    public String getAuthorName() {
        return this.authorName;
    }

    public MapValue setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public MapValue setModifiedTime(String modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public String getModifiedTime() {
        return this.modifiedTime;
    }

    public MapValue setWorkspaceId(String workspaceId) {
        this.workspaceId = workspaceId;
        return this;
    }
    public String getWorkspaceId() {
        return this.workspaceId;
    }

    public MapValue setWorkspaceName(String workspaceName) {
        this.workspaceName = workspaceName;
        return this;
    }
    public String getWorkspaceName() {
        return this.workspaceName;
    }

    public MapValue setUsedCount(Long usedCount) {
        this.usedCount = usedCount;
        return this;
    }
    public Long getUsedCount() {
        return this.usedCount;
    }

    public MapValue setBelong(String belong) {
        this.belong = belong;
        return this;
    }
    public String getBelong() {
        return this.belong;
    }

    public MapValue setContentDownloadUrl(String contentDownloadUrl) {
        this.contentDownloadUrl = contentDownloadUrl;
        return this;
    }
    public String getContentDownloadUrl() {
        return this.contentDownloadUrl;
    }

}
