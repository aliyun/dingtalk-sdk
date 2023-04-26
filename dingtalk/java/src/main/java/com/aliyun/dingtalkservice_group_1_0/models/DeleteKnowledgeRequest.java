// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class DeleteKnowledgeRequest extends TeaModel {
    @NameInMap("libraryKey")
    public String libraryKey;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("source")
    public String source;

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
