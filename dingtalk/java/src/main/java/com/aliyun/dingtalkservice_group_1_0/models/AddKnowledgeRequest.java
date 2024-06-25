// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddKnowledgeRequest extends TeaModel {
    @NameInMap("attachmentList")
    public java.util.List<AddKnowledgeRequestAttachmentList> attachmentList;

    /**
     * <strong>example:</strong>
     * <p>测试内容</p>
     */
    @NameInMap("content")
    public String content;

    @NameInMap("effectTimeend")
    public Long effectTimeend;

    @NameInMap("effectTimestart")
    public Long effectTimestart;

    @NameInMap("extTitle")
    public String extTitle;

    @NameInMap("keyword")
    public String keyword;

    /**
     * <strong>example:</strong>
     * <p>xuvw1245</p>
     */
    @NameInMap("libraryKey")
    public String libraryKey;

    /**
     * <strong>example:</strong>
     * <p><a href="http://www.test.com/xxxxx">http://www.test.com/xxxxx</a></p>
     */
    @NameInMap("linkUrl")
    public String linkUrl;

    /**
     * <strong>example:</strong>
     * <p>Jxi12wo3qxoa</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("questionIds")
    public java.util.List<Long> questionIds;

    /**
     * <strong>example:</strong>
     * <p>CCM</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <strong>example:</strong>
     * <p>CCM-123</p>
     */
    @NameInMap("sourcePrimaryKey")
    public String sourcePrimaryKey;

    /**
     * <strong>example:</strong>
     * <p>测试</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <strong>example:</strong>
     * <p>CONDITION</p>
     */
    @NameInMap("type")
    public String type;

    /**
     * <strong>example:</strong>
     * <p>V0193859102</p>
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
         * <strong>example:</strong>
         * <p>doc</p>
         */
        @NameInMap("mime_type")
        public String mimeType;

        @NameInMap("path")
        public String path;

        /**
         * <strong>example:</strong>
         * <p>655</p>
         */
        @NameInMap("size")
        public Long size;

        /**
         * <strong>example:</strong>
         * <p>pdf</p>
         */
        @NameInMap("suffix")
        public String suffix;

        /**
         * <strong>example:</strong>
         * <p>测试附件</p>
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
