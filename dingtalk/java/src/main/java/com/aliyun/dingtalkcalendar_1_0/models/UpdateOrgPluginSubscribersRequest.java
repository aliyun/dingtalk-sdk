// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrgPluginSubscribersRequest extends TeaModel {
    @NameInMap("deptIds")
    public java.util.List<String> deptIds;

    @NameInMap("unionIds")
    public java.util.List<String> unionIds;

    public static UpdateOrgPluginSubscribersRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrgPluginSubscribersRequest self = new UpdateOrgPluginSubscribersRequest();
        return TeaModel.build(map, self);
    }

    public UpdateOrgPluginSubscribersRequest setDeptIds(java.util.List<String> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<String> getDeptIds() {
        return this.deptIds;
    }

    public UpdateOrgPluginSubscribersRequest setUnionIds(java.util.List<String> unionIds) {
        this.unionIds = unionIds;
        return this;
    }
    public java.util.List<String> getUnionIds() {
        return this.unionIds;
    }

}
