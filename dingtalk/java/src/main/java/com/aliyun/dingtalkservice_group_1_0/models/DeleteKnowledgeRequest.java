// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class DeleteKnowledgeRequest extends TeaModel {
    // 知识库的唯一标识 比如:天工知识库ID
    @NameInMap("libraryKey")
    public String libraryKey;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 知识点来源 CCM:天工知识库
    @NameInMap("source")
    public String source;

    // 知识点唯一标识
    @NameInMap("sourcePrimaryKey")
    public String sourcePrimaryKey;

    public static DeleteKnowledgeRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteKnowledgeRequest self = new DeleteKnowledgeRequest();
        return TeaModel.build(map, self);
    }

    public DeleteKnowledgeRequest setLibraryKey(String libraryKey) {
        this.libraryKey = libraryKey;
        return this;
    }
    public String getLibraryKey() {
        return this.libraryKey;
    }

    public DeleteKnowledgeRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public DeleteKnowledgeRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public DeleteKnowledgeRequest setSourcePrimaryKey(String sourcePrimaryKey) {
        this.sourcePrimaryKey = sourcePrimaryKey;
        return this;
    }
    public String getSourcePrimaryKey() {
        return this.sourcePrimaryKey;
    }

}
