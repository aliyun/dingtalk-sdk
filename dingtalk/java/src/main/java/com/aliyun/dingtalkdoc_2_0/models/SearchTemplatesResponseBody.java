// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SearchTemplatesResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("templateList")
    public java.util.List<SearchTemplatesResponseBodyTemplateList> templateList;

    public static SearchTemplatesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchTemplatesResponseBody self = new SearchTemplatesResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchTemplatesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchTemplatesResponseBody setTemplateList(java.util.List<SearchTemplatesResponseBodyTemplateList> templateList) {
        this.templateList = templateList;
        return this;
    }
    public java.util.List<SearchTemplatesResponseBodyTemplateList> getTemplateList() {
        return this.templateList;
    }

    public static class SearchTemplatesResponseBodyTemplateList extends TeaModel {
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

        public static SearchTemplatesResponseBodyTemplateList build(java.util.Map<String, ?> map) throws Exception {
            SearchTemplatesResponseBodyTemplateList self = new SearchTemplatesResponseBodyTemplateList();
            return TeaModel.build(map, self);
        }

        public SearchTemplatesResponseBodyTemplateList setAuthorName(String authorName) {
            this.authorName = authorName;
            return this;
        }
        public String getAuthorName() {
            return this.authorName;
        }

        public SearchTemplatesResponseBodyTemplateList setBelong(String belong) {
            this.belong = belong;
            return this;
        }
        public String getBelong() {
            return this.belong;
        }

        public SearchTemplatesResponseBodyTemplateList setContentDownloadUrl(String contentDownloadUrl) {
            this.contentDownloadUrl = contentDownloadUrl;
            return this;
        }
        public String getContentDownloadUrl() {
            return this.contentDownloadUrl;
        }

        public SearchTemplatesResponseBodyTemplateList setCoverDownloadUrl(String coverDownloadUrl) {
            this.coverDownloadUrl = coverDownloadUrl;
            return this;
        }
        public String getCoverDownloadUrl() {
            return this.coverDownloadUrl;
        }

        public SearchTemplatesResponseBodyTemplateList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public SearchTemplatesResponseBodyTemplateList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public SearchTemplatesResponseBodyTemplateList setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public SearchTemplatesResponseBodyTemplateList setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public SearchTemplatesResponseBodyTemplateList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SearchTemplatesResponseBodyTemplateList setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public SearchTemplatesResponseBodyTemplateList setUsedCount(Long usedCount) {
            this.usedCount = usedCount;
            return this;
        }
        public Long getUsedCount() {
            return this.usedCount;
        }

        public SearchTemplatesResponseBodyTemplateList setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

        public SearchTemplatesResponseBodyTemplateList setWorkspaceName(String workspaceName) {
            this.workspaceName = workspaceName;
            return this;
        }
        public String getWorkspaceName() {
            return this.workspaceName;
        }

    }

}
