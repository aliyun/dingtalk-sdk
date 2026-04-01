// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupFromOldGroupRequest extends TeaModel {
    @NameInMap("notQuitWhenEmpLeave")
    public Long notQuitWhenEmpLeave;

    @NameInMap("srcCorpId")
    public String srcCorpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("srcOpenConversationId")
    public String srcOpenConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("uuid")
    public String uuid;

    public static CreateGroupFromOldGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupFromOldGroupRequest self = new CreateGroupFromOldGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupFromOldGroupRequest setNotQuitWhenEmpLeave(Long notQuitWhenEmpLeave) {
        this.notQuitWhenEmpLeave = notQuitWhenEmpLeave;
        return this;
    }
    public Long getNotQuitWhenEmpLeave() {
        return this.notQuitWhenEmpLeave;
    }

    public CreateGroupFromOldGroupRequest setSrcCorpId(String srcCorpId) {
        this.srcCorpId = srcCorpId;
        return this;
    }
    public String getSrcCorpId() {
        return this.srcCorpId;
    }

    public CreateGroupFromOldGroupRequest setSrcOpenConversationId(String srcOpenConversationId) {
        this.srcOpenConversationId = srcOpenConversationId;
        return this;
    }
    public String getSrcOpenConversationId() {
        return this.srcOpenConversationId;
    }

    public CreateGroupFromOldGroupRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public CreateGroupFromOldGroupRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
