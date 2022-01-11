// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateTeamRequest extends TeaModel {
    // 团队管理员钉钉unionId
    @NameInMap("creatorDingUnionId")
    public String creatorDingUnionId;

    // 团队名字
    @NameInMap("teamName")
    public String teamName;

    public static CreateTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTeamRequest self = new CreateTeamRequest();
        return TeaModel.build(map, self);
    }

    public CreateTeamRequest setCreatorDingUnionId(String creatorDingUnionId) {
        this.creatorDingUnionId = creatorDingUnionId;
        return this;
    }
    public String getCreatorDingUnionId() {
        return this.creatorDingUnionId;
    }

    public CreateTeamRequest setTeamName(String teamName) {
        this.teamName = teamName;
        return this;
    }
    public String getTeamName() {
        return this.teamName;
    }

}
