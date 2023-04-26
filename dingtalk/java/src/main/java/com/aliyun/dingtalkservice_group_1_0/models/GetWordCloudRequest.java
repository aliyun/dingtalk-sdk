// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetWordCloudRequest extends TeaModel {
    @NameInMap("openTeamId")
    public String openTeamId;

    public static GetWordCloudRequest build(java.util.Map<String, ?> map) throws Exception {
        GetWordCloudRequest self = new GetWordCloudRequest();
        return TeaModel.build(map, self);
    }

    public GetWordCloudRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
