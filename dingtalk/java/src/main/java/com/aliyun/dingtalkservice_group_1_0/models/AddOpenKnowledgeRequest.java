// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenKnowledgeRequest extends TeaModel {
    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // 所属团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 用户ID
    @NameInMap("userId")
    public String userId;

    // 用户昵称或姓名
    @NameInMap("userName")
    public String userName;

    // 附件列表
    @NameInMap("attachments")
    public java.util.List<AddOpenKnowledgeRequestAttachments> attachments;

    // 所属知识库唯一标识id
    @NameInMap("libraryId")
    public Long libraryId;

    // 知识点来源
    @NameInMap("source")
    public String source;

    // 知识点标准问
    @NameInMap("title")
    public String title;

    // 知识点类型()
    @NameInMap("type")
    public String type;

    // 知识点正文
    @NameInMap("content")
    public String content;

    // 扩展问法(多个英文逗号隔开)
    @NameInMap("extTitle")
    public String extTitle;

    // 关键词(多个逗号隔开)
    @NameInMap("keyword")
    public String keyword;

    // 标签(多个可逗号隔开)
    @NameInMap("tags")
    public String tags;

    // 生效开始时间(默认1980-01-01 00:00:00)
    @NameInMap("effectTimestart")
    public String effectTimestart;

    // 生效结束时间(默认2100-01-01 23:59:59)
    @NameInMap("effectTimeend")
    public String effectTimeend;

    // 知识点所属类目ID
    @NameInMap("categoryId")
    public Long categoryId;

    public static AddOpenKnowledgeRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOpenKnowledgeRequest self = new AddOpenKnowledgeRequest();
        return TeaModel.build(map, self);
    }

    public AddOpenKnowledgeRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public AddOpenKnowledgeRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public AddOpenKnowledgeRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public AddOpenKnowledgeRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public AddOpenKnowledgeRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
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

    public AddOpenKnowledgeRequest setAttachments(java.util.List<AddOpenKnowledgeRequestAttachments> attachments) {
        this.attachments = attachments;
        return this;
    }
    public java.util.List<AddOpenKnowledgeRequestAttachments> getAttachments() {
        return this.attachments;
    }

    public AddOpenKnowledgeRequest setLibraryId(Long libraryId) {
        this.libraryId = libraryId;
        return this;
    }
    public Long getLibraryId() {
        return this.libraryId;
    }

    public AddOpenKnowledgeRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
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

    public AddOpenKnowledgeRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
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

    public AddOpenKnowledgeRequest setTags(String tags) {
        this.tags = tags;
        return this;
    }
    public String getTags() {
        return this.tags;
    }

    public AddOpenKnowledgeRequest setEffectTimestart(String effectTimestart) {
        this.effectTimestart = effectTimestart;
        return this;
    }
    public String getEffectTimestart() {
        return this.effectTimestart;
    }

    public AddOpenKnowledgeRequest setEffectTimeend(String effectTimeend) {
        this.effectTimeend = effectTimeend;
        return this;
    }
    public String getEffectTimeend() {
        return this.effectTimeend;
    }

    public AddOpenKnowledgeRequest setCategoryId(Long categoryId) {
        this.categoryId = categoryId;
        return this;
    }
    public Long getCategoryId() {
        return this.categoryId;
    }

    public static class AddOpenKnowledgeRequestAttachments extends TeaModel {
        // 附件名称
        @NameInMap("title")
        public String title;

        // 这个是附件URL
        @NameInMap("path")
        public String path;

        // 附件大小
        @NameInMap("size")
        public Double size;

        // 附件扩展名
        @NameInMap("suffix")
        public String suffix;

        // 媒体类型
        @NameInMap("mimeType")
        public String mimeType;

        public static AddOpenKnowledgeRequestAttachments build(java.util.Map<String, ?> map) throws Exception {
            AddOpenKnowledgeRequestAttachments self = new AddOpenKnowledgeRequestAttachments();
            return TeaModel.build(map, self);
        }

        public AddOpenKnowledgeRequestAttachments setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
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

        public AddOpenKnowledgeRequestAttachments setMimeType(String mimeType) {
            this.mimeType = mimeType;
            return this;
        }
        public String getMimeType() {
            return this.mimeType;
        }

    }

}
