// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenKnowledgeRequest extends TeaModel {
    @NameInMap("attachments")
    public java.util.List<AddOpenKnowledgeRequestAttachments> attachments;

    @NameInMap("categoryId")
    public Long categoryId;

    @NameInMap("content")
    public String content;

    @NameInMap("effectTimeend")
    public String effectTimeend;

    @NameInMap("effectTimestart")
    public String effectTimestart;

    @NameInMap("extTitle")
    public String extTitle;

    @NameInMap("keyword")
    public String keyword;

    @NameInMap("libraryId")
    public Long libraryId;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("source")
    public String source;

    @NameInMap("tags")
    public String tags;

    @NameInMap("title")
    public String title;

    @NameInMap("type")
    public String type;

    @NameInMap("userId")
    public String userId;

    @NameInMap("userName")
    public String userName;

    public static AddOpenKnowledgeRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOpenKnowledgeRequest self = new AddOpenKnowledgeRequest();
        return TeaModel.build(map, self);
    }

    public AddOpenKnowledgeRequest setAttachments(java.util.List<AddOpenKnowledgeRequestAttachments> attachments) {
        this.attachments = attachments;
        return this;
    }
    public java.util.List<AddOpenKnowledgeRequestAttachments> getAttachments() {
        return this.attachments;
    }

    public AddOpenKnowledgeRequest setCategoryId(Long categoryId) {
        this.categoryId = categoryId;
        return this;
    }
    public Long getCategoryId() {
        return this.categoryId;
    }

    public AddOpenKnowledgeRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public AddOpenKnowledgeRequest setEffectTimeend(String effectTimeend) {
        this.effectTimeend = effectTimeend;
        return this;
    }
    public String getEffectTimeend() {
        return this.effectTimeend;
    }

    public AddOpenKnowledgeRequest setEffectTimestart(String effectTimestart) {
        this.effectTimestart = effectTimestart;
        return this;
    }
    public String getEffectTimestart() {
        return this.effectTimestart;
    }

    public AddOpenKnowledgeRequest setExtTitle(String extTitle) {
        this.extTitle = extTitle;
        return this;
    }
    public String getExtTitle() {
        return this.extTitle;
    }

    public AddOpenKnowledgeRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public AddOpenKnowledgeRequest setLibraryId(Long libraryId) {
        this.libraryId = libraryId;
        return this;
    }
    public Long getLibraryId() {
        return this.libraryId;
    }

    public AddOpenKnowledgeRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public AddOpenKnowledgeRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public AddOpenKnowledgeRequest setTags(String tags) {
        this.tags = tags;
        return this;
    }
    public String getTags() {
        return this.tags;
    }

    public AddOpenKnowledgeRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddOpenKnowledgeRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public AddOpenKnowledgeRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public AddOpenKnowledgeRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public static class AddOpenKnowledgeRequestAttachments extends TeaModel {
        @NameInMap("mimeType")
        public String mimeType;

        @NameInMap("path")
        public String path;

        @NameInMap("size")
        public Double size;

        @NameInMap("suffix")
        public String suffix;

        @NameInMap("title")
        public String title;

        public static AddOpenKnowledgeRequestAttachments build(java.util.Map<String, ?> map) throws Exception {
            AddOpenKnowledgeRequestAttachments self = new AddOpenKnowledgeRequestAttachments();
            return TeaModel.build(map, self);
        }

        public AddOpenKnowledgeRequestAttachments setMimeType(String mimeType) {
            this.mimeType = mimeType;
            return this;
        }
        public String getMimeType() {
            return this.mimeType;
        }

        public AddOpenKnowledgeRequestAttachments setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public AddOpenKnowledgeRequestAttachments setSize(Double size) {
            this.size = size;
            return this;
        }
        public Double getSize() {
            return this.size;
        }

        public AddOpenKnowledgeRequestAttachments setSuffix(String suffix) {
            this.suffix = suffix;
            return this;
        }
        public String getSuffix() {
            return this.suffix;
        }

        public AddOpenKnowledgeRequestAttachments setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
