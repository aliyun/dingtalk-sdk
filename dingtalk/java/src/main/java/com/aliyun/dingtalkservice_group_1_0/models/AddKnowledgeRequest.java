// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddKnowledgeRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 知识库的唯一标识
    @NameInMap("libraryKey")
    public String libraryKey;

    // 知识点来源
    @NameInMap("source")
    public String source;

    // 知识点唯一标识
    @NameInMap("sourcePrimaryKey")
    public String sourcePrimaryKey;

    // 知识点类型 NORMAL：普通型 CARD：卡片 CONDITION：条件
    @NameInMap("type")
    public String type;

    // 知识点名称
    @NameInMap("title")
    public String title;

    // 知识点内容
    @NameInMap("content")
    public String content;

    // 知识点扩展问(多个用英文逗号隔开)
    @NameInMap("extTitle")
    public String extTitle;

    // 关键字(多个用英文逗号隔开)
    @NameInMap("keyword")
    public String keyword;

    // 附件列表
    @NameInMap("attachmentList")
    public java.util.List<AddKnowledgeRequestAttachmentList> attachmentList;

    // CCM的知识点外链
    @NameInMap("linkUrl")
    public String linkUrl;

    // 知识点版本号
    @NameInMap("version")
    public String version;

    public static AddKnowledgeRequest build(java.util.Map<String, ?> map) throws Exception {
        AddKnowledgeRequest self = new AddKnowledgeRequest();
        return TeaModel.build(map, self);
    }

    public AddKnowledgeRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public AddKnowledgeRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public AddKnowledgeRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public AddKnowledgeRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public AddKnowledgeRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public AddKnowledgeRequest setLibraryKey(String libraryKey) {
        this.libraryKey = libraryKey;
        return this;
    }
    public String getLibraryKey() {
        return this.libraryKey;
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

    public AddKnowledgeRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public AddKnowledgeRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddKnowledgeRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
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

    public AddKnowledgeRequest setAttachmentList(java.util.List<AddKnowledgeRequestAttachmentList> attachmentList) {
        this.attachmentList = attachmentList;
        return this;
    }
    public java.util.List<AddKnowledgeRequestAttachmentList> getAttachmentList() {
        return this.attachmentList;
    }

    public AddKnowledgeRequest setLinkUrl(String linkUrl) {
        this.linkUrl = linkUrl;
        return this;
    }
    public String getLinkUrl() {
        return this.linkUrl;
    }

    public AddKnowledgeRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

    public static class AddKnowledgeRequestAttachmentList extends TeaModel {
        // 附件名称
        @NameInMap("title")
        public String title;

        // 附件URL
        @NameInMap("path")
        public String path;

        // 附件大小
        @NameInMap("size")
        public Long size;

        // 附件扩展名
        @NameInMap("suffix")
        public String suffix;

        // 多媒体类型
        @NameInMap("mime_type")
        public String mimeType;

        public static AddKnowledgeRequestAttachmentList build(java.util.Map<String, ?> map) throws Exception {
            AddKnowledgeRequestAttachmentList self = new AddKnowledgeRequestAttachmentList();
            return TeaModel.build(map, self);
        }

        public AddKnowledgeRequestAttachmentList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
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

        public AddKnowledgeRequestAttachmentList setMimeType(String mimeType) {
            this.mimeType = mimeType;
            return this;
        }
        public String getMimeType() {
            return this.mimeType;
        }

    }

}
