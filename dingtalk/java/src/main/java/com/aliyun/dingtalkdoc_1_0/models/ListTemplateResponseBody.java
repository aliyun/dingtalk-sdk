// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ListTemplateResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("templateList")
    public java.util.List<ListTemplateResponseBodyTemplateList> templateList;

    public static ListTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListTemplateResponseBody self = new ListTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public ListTemplateResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListTemplateResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListTemplateResponseBody setTemplateList(java.util.List<ListTemplateResponseBodyTemplateList> templateList) {
        this.templateList = templateList;
        return this;
    }
    public java.util.List<ListTemplateResponseBodyTemplateList> getTemplateList() {
        return this.templateList;
    }

    public static class ListTemplateResponseBodyTemplateList extends TeaModel {
        @NameInMap("coverUrl")
        public String coverUrl;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("docType")
        public String docType;

        @NameInMap("id")
        public String id;

        @NameInMap("templateType")
        public String templateType;

        @NameInMap("title")
        public String title;

        @NameInMap("updateTime")
        public Long updateTime;

        @NameInMap("workspaceId")
        public String workspaceId;

        public static ListTemplateResponseBodyTemplateList build(java.util.Map<String, ?> map) throws Exception {
            ListTemplateResponseBodyTemplateList self = new ListTemplateResponseBodyTemplateList();
            return TeaModel.build(map, self);
        }

        public ListTemplateResponseBodyTemplateList setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public ListTemplateResponseBodyTemplateList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public ListTemplateResponseBodyTemplateList setDocType(String docType) {
            this.docType = docType;
            return this;
        }
        public String getDocType() {
            return this.docType;
        }

        public ListTemplateResponseBodyTemplateList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListTemplateResponseBodyTemplateList setTemplateType(String templateType) {
            this.templateType = templateType;
            return this;
        }
        public String getTemplateType() {
            return this.templateType;
        }

        public ListTemplateResponseBodyTemplateList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public ListTemplateResponseBodyTemplateList setUpdateTime(Long updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public Long getUpdateTime() {
            return this.updateTime;
        }

        public ListTemplateResponseBodyTemplateList setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
