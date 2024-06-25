// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class TeamTemplatesResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>next_token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("templateList")
    public java.util.List<TeamTemplatesResponseBodyTemplateList> templateList;

    public static TeamTemplatesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TeamTemplatesResponseBody self = new TeamTemplatesResponseBody();
        return TeaModel.build(map, self);
    }

    public TeamTemplatesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public TeamTemplatesResponseBody setTemplateList(java.util.List<TeamTemplatesResponseBodyTemplateList> templateList) {
        this.templateList = templateList;
        return this;
    }
    public java.util.List<TeamTemplatesResponseBodyTemplateList> getTemplateList() {
        return this.templateList;
    }

    public static class TeamTemplatesResponseBodyTemplateList extends TeaModel {
        @NameInMap("authorName")
        public String authorName;

        @NameInMap("belong")
        public String belong;

        @NameInMap("contentDownloadUrl")
        public String contentDownloadUrl;

        @NameInMap("coverDownloadUrl")
        public String coverDownloadUrl;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("description")
        public String description;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("templateId")
        public String templateId;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public Integer type;

        @NameInMap("usedCount")
        public Long usedCount;

        @NameInMap("workspaceId")
        public String workspaceId;

        @NameInMap("workspaceName")
        public String workspaceName;

        public static TeamTemplatesResponseBodyTemplateList build(java.util.Map<String, ?> map) throws Exception {
            TeamTemplatesResponseBodyTemplateList self = new TeamTemplatesResponseBodyTemplateList();
            return TeaModel.build(map, self);
        }

        public TeamTemplatesResponseBodyTemplateList setAuthorName(String authorName) {
            this.authorName = authorName;
            return this;
        }
        public String getAuthorName() {
            return this.authorName;
        }

        public TeamTemplatesResponseBodyTemplateList setBelong(String belong) {
            this.belong = belong;
            return this;
        }
        public String getBelong() {
            return this.belong;
        }

        public TeamTemplatesResponseBodyTemplateList setContentDownloadUrl(String contentDownloadUrl) {
            this.contentDownloadUrl = contentDownloadUrl;
            return this;
        }
        public String getContentDownloadUrl() {
            return this.contentDownloadUrl;
        }

        public TeamTemplatesResponseBodyTemplateList setCoverDownloadUrl(String coverDownloadUrl) {
            this.coverDownloadUrl = coverDownloadUrl;
            return this;
        }
        public String getCoverDownloadUrl() {
            return this.coverDownloadUrl;
        }

        public TeamTemplatesResponseBodyTemplateList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public TeamTemplatesResponseBodyTemplateList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public TeamTemplatesResponseBodyTemplateList setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public TeamTemplatesResponseBodyTemplateList setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public TeamTemplatesResponseBodyTemplateList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public TeamTemplatesResponseBodyTemplateList setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public TeamTemplatesResponseBodyTemplateList setUsedCount(Long usedCount) {
            this.usedCount = usedCount;
            return this;
        }
        public Long getUsedCount() {
            return this.usedCount;
        }

        public TeamTemplatesResponseBodyTemplateList setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

        public TeamTemplatesResponseBodyTemplateList setWorkspaceName(String workspaceName) {
            this.workspaceName = workspaceName;
            return this;
        }
        public String getWorkspaceName() {
            return this.workspaceName;
        }

    }

}
