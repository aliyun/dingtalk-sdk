// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddKnowledgeRequest extends TeaModel {
    /**
     * <p>附件列表</p>
     */
    @NameInMap("attachmentList")
    public java.util.List<AddKnowledgeRequestAttachmentList> attachmentList;

    /**
     * <p>知识点内容</p>
     */
    @NameInMap("content")
    public String content;

    @NameInMap("effectTimeend")
    public Long effectTimeend;

    @NameInMap("effectTimestart")
    public Long effectTimestart;

    /**
     * <p>知识点扩展问(多个用英文逗号隔开)</p>
     */
    @NameInMap("extTitle")
    public String extTitle;

    /**
     * <p>关键字(多个用英文逗号隔开)</p>
     */
    @NameInMap("keyword")
    public String keyword;

    /**
     * <p>知识库的唯一标识</p>
     */
    @NameInMap("libraryKey")
    public String libraryKey;

    /**
     * <p>CCM的知识点外链</p>
     */
    @NameInMap("linkUrl")
    public String linkUrl;

    /**
     * <p>开放团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>关联问题id</p>
     */
    @NameInMap("questionIds")
    public java.util.List<Long> questionIds;

    /**
     * <p>知识点来源</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <p>知识点唯一标识</p>
     */
    @NameInMap("sourcePrimaryKey")
    public String sourcePrimaryKey;

    /**
     * <p>知识点名称</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>知识点类型 NORMAL：普通型 CARD：卡片 CONDITION：条件</p>
     */
    @NameInMap("type")
    public String type;

    /**
     * <p>知识点版本号</p>
     */
    @NameInMap("version")
    public String version;

    public static AddKnowledgeRequest build(java.util.Map<String, ?> map) throws Exception {
        AddKnowledgeRequest self = new AddKnowledgeRequest();
        return TeaModel.build(map, self);
    }

    public AddKnowledgeRequest setAttachmentList(java.util.List<AddKnowledgeRequestAttachmentList> attachmentList) {
        this.attachmentList = attachmentList;
        return this;
    }
    public java.util.List<AddKnowledgeRequestAttachmentList> getAttachmentList() {
        return this.attachmentList;
    }

    public AddKnowledgeRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public AddKnowledgeRequest setEffectTimeend(Long effectTimeend) {
        this.effectTimeend = effectTimeend;
        return this;
    }
    public Long getEffectTimeend() {
        return this.effectTimeend;
    }

    public AddKnowledgeRequest setEffectTimestart(Long effectTimestart) {
        this.effectTimestart = effectTimestart;
        return this;
    }
    public Long getEffectTimestart() {
        return this.effectTimestart;
    }

    public AddKnowledgeRequest setExtTitle(String extTitle) {
        this.extTitle = extTitle;
        return this;
    }
    public String getExtTitle() {
        return this.extTitle;
    }

    public AddKnowledgeRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public AddKnowledgeRequest setLibraryKey(String libraryKey) {
        this.libraryKey = libraryKey;
        return this;
    }
    public String getLibraryKey() {
        return this.libraryKey;
    }

    public AddKnowledgeRequest setLinkUrl(String linkUrl) {
        this.linkUrl = linkUrl;
        return this;
    }
    public String getLinkUrl() {
        return this.linkUrl;
    }

    public AddKnowledgeRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public AddKnowledgeRequest setQuestionIds(java.util.List<Long> questionIds) {
        this.questionIds = questionIds;
        return this;
    }
    public java.util.List<Long> getQuestionIds() {
        return this.questionIds;
    }

    public AddKnowledgeRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public AddKnowledgeRequest setSourcePrimaryKey(String sourcePrimaryKey) {
        this.sourcePrimaryKey = sourcePrimaryKey;
        return this;
    }
    public String getSourcePrimaryKey() {
        return this.sourcePrimaryKey;
    }

    public AddKnowledgeRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddKnowledgeRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public AddKnowledgeRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

    public static class AddKnowledgeRequestAttachmentList extends TeaModel {
        /**
         * <p>多媒体类型</p>
         */
        @NameInMap("mime_type")
        public String mimeType;

        /**
         * <p>附件URL</p>
         */
        @NameInMap("path")
        public String path;

        /**
         * <p>附件大小</p>
         */
        @NameInMap("size")
        public Long size;

        /**
         * <p>附件扩展名</p>
         */
        @NameInMap("suffix")
        public String suffix;

        /**
         * <p>附件名称</p>
         */
        @NameInMap("title")
        public String title;

        public static AddKnowledgeRequestAttachmentList build(java.util.Map<String, ?> map) throws Exception {
            AddKnowledgeRequestAttachmentList self = new AddKnowledgeRequestAttachmentList();
            return TeaModel.build(map, self);
        }

        public AddKnowledgeRequestAttachmentList setMimeType(String mimeType) {
            this.mimeType = mimeType;
            return this;
        }
        public String getMimeType() {
            return this.mimeType;
        }

        public AddKnowledgeRequestAttachmentList setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public AddKnowledgeRequestAttachmentList setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public AddKnowledgeRequestAttachmentList setSuffix(String suffix) {
            this.suffix = suffix;
            return this;
        }
        public String getSuffix() {
            return this.suffix;
        }

        public AddKnowledgeRequestAttachmentList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
