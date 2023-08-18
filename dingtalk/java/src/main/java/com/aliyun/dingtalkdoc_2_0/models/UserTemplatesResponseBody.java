// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UserTemplatesResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("templateList")
    public java.util.List<UserTemplatesResponseBodyTemplateList> templateList;

    public static UserTemplatesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UserTemplatesResponseBody self = new UserTemplatesResponseBody();
        return TeaModel.build(map, self);
    }

    public UserTemplatesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public UserTemplatesResponseBody setTemplateList(java.util.List<UserTemplatesResponseBodyTemplateList> templateList) {
        this.templateList = templateList;
        return this;
    }
    public java.util.List<UserTemplatesResponseBodyTemplateList> getTemplateList() {
        return this.templateList;
    }

    public static class UserTemplatesResponseBodyTemplateList extends TeaModel {
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

        public static UserTemplatesResponseBodyTemplateList build(java.util.Map<String, ?> map) throws Exception {
            UserTemplatesResponseBodyTemplateList self = new UserTemplatesResponseBodyTemplateList();
            return TeaModel.build(map, self);
        }

        public UserTemplatesResponseBodyTemplateList setAuthorName(String authorName) {
            this.authorName = authorName;
            return this;
        }
        public String getAuthorName() {
            return this.authorName;
        }

        public UserTemplatesResponseBodyTemplateList setBelong(String belong) {
            this.belong = belong;
            return this;
        }
        public String getBelong() {
            return this.belong;
        }

        public UserTemplatesResponseBodyTemplateList setContentDownloadUrl(String contentDownloadUrl) {
            this.contentDownloadUrl = contentDownloadUrl;
            return this;
        }
        public String getContentDownloadUrl() {
            return this.contentDownloadUrl;
        }

        public UserTemplatesResponseBodyTemplateList setCoverDownloadUrl(String coverDownloadUrl) {
            this.coverDownloadUrl = coverDownloadUrl;
            return this;
        }
        public String getCoverDownloadUrl() {
            return this.coverDownloadUrl;
        }

        public UserTemplatesResponseBodyTemplateList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public UserTemplatesResponseBodyTemplateList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public UserTemplatesResponseBodyTemplateList setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public UserTemplatesResponseBodyTemplateList setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public UserTemplatesResponseBodyTemplateList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public UserTemplatesResponseBodyTemplateList setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public UserTemplatesResponseBodyTemplateList setUsedCount(Long usedCount) {
            this.usedCount = usedCount;
            return this;
        }
        public Long getUsedCount() {
            return this.usedCount;
        }

        public UserTemplatesResponseBodyTemplateList setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

        public UserTemplatesResponseBodyTemplateList setWorkspaceName(String workspaceName) {
            this.workspaceName = workspaceName;
            return this;
        }
        public String getWorkspaceName() {
            return this.workspaceName;
        }

    }

}
