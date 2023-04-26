// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetNegativeWordCloudRequest extends TeaModel {
    @NameInMap("openTeamId")
    public String openTeamId;

    public static GetNegativeWordCloudRequest build(java.util.Map<String, ?> map) throws Exception {
        GetNegativeWordCloudRequest self = new GetNegativeWordCloudRequest();
        return TeaModel.build(map, self);
    }

    public GetNegativeWordCloudRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
