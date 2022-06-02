// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetInstancesByIdsRequest extends TeaModel {
    // 表单CODE
    @NameInMap("formCode")
    public String formCode;

    // 开放数据实例ID集合
    @NameInMap("openDataInstanceIdList")
    public java.util.List<String> openDataInstanceIdList;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    public static GetInstancesByIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInstancesByIdsRequest self = new GetInstancesByIdsRequest();
        return TeaModel.build(map, self);
    }

    public GetInstancesByIdsRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public GetInstancesByIdsRequest setOpenDataInstanceIdList(java.util.List<String> openDataInstanceIdList) {
        this.openDataInstanceIdList = openDataInstanceIdList;
        return this;
    }
    public java.util.List<String> getOpenDataInstanceIdList() {
        return this.openDataInstanceIdList;
    }

    public GetInstancesByIdsRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
