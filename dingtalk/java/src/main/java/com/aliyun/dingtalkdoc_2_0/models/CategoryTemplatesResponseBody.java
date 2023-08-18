// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CategoryTemplatesResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<CategoryTemplatesResponseBodyList> list;

    public static CategoryTemplatesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CategoryTemplatesResponseBody self = new CategoryTemplatesResponseBody();
        return TeaModel.build(map, self);
    }

    public CategoryTemplatesResponseBody setList(java.util.List<CategoryTemplatesResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<CategoryTemplatesResponseBodyList> getList() {
        return this.list;
    }

    public static class CategoryTemplatesResponseBodyList extends TeaModel {
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

        public static CategoryTemplatesResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            CategoryTemplatesResponseBodyList self = new CategoryTemplatesResponseBodyList();
            return TeaModel.build(map, self);
        }

        public CategoryTemplatesResponseBodyList setAuthorName(String authorName) {
            this.authorName = authorName;
            return this;
        }
        public String getAuthorName() {
            return this.authorName;
        }

        public CategoryTemplatesResponseBodyList setBelong(String belong) {
            this.belong = belong;
            return this;
        }
        public String getBelong() {
            return this.belong;
        }

        public CategoryTemplatesResponseBodyList setContentDownloadUrl(String contentDownloadUrl) {
            this.contentDownloadUrl = contentDownloadUrl;
            return this;
        }
        public String getContentDownloadUrl() {
            return this.contentDownloadUrl;
        }

        public CategoryTemplatesResponseBodyList setCoverDownloadUrl(String coverDownloadUrl) {
            this.coverDownloadUrl = coverDownloadUrl;
            return this;
        }
        public String getCoverDownloadUrl() {
            return this.coverDownloadUrl;
        }

        public CategoryTemplatesResponseBodyList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public CategoryTemplatesResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CategoryTemplatesResponseBodyList setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public CategoryTemplatesResponseBodyList setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public CategoryTemplatesResponseBodyList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CategoryTemplatesResponseBodyList setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public CategoryTemplatesResponseBodyList setUsedCount(Long usedCount) {
            this.usedCount = usedCount;
            return this;
        }
        public Long getUsedCount() {
            return this.usedCount;
        }

        public CategoryTemplatesResponseBodyList setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

        public CategoryTemplatesResponseBodyList setWorkspaceName(String workspaceName) {
            this.workspaceName = workspaceName;
            return this;
        }
        public String getWorkspaceName() {
            return this.workspaceName;
        }

    }

}
