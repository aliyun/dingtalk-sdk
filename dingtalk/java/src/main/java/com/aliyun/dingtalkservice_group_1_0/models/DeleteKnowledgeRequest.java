// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class DeleteKnowledgeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xuvw1245</p>
     */
    @NameInMap("libraryKey")
    public String libraryKey;

    /**
     * <strong>example:</strong>
     * <p>Js1i0w3k</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

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
