// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupSetRequest extends TeaModel {
    @NameInMap("groupSetName")
    public String groupSetName;

    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    @NameInMap("openTeamId")
    public String openTeamId;

    public static CreateGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupSetRequest self = new CreateGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupSetRequest setGroupSetName(String groupSetName) {
        this.groupSetName = groupSetName;
        return this;
    }
    public String getGroupSetName() {
        return this.groupSetName;
    }

    public CreateGroupSetRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public CreateGroupSetRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
