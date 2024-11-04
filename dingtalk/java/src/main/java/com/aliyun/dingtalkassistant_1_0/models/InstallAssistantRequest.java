// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class InstallAssistantRequest extends TeaModel {
    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("isAllOrgMemberVisible")
    public Boolean isAllOrgMemberVisible;

    public static InstallAssistantRequest build(java.util.Map<String, ?> map) throws Exception {
        InstallAssistantRequest self = new InstallAssistantRequest();
        return TeaModel.build(map, self);
    }

    public InstallAssistantRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public InstallAssistantRequest setIsAllOrgMemberVisible(Boolean isAllOrgMemberVisible) {
        this.isAllOrgMemberVisible = isAllOrgMemberVisible;
        return this;
    }
    public Boolean getIsAllOrgMemberVisible() {
        return this.isAllOrgMemberVisible;
    }

}
