// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupOrgByCidResponseBody extends TeaModel {
    @NameInMap("groupOrganization")
    public Long groupOrganization;

    public static GetGroupOrgByCidResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetGroupOrgByCidResponseBody self = new GetGroupOrgByCidResponseBody();
        return TeaModel.build(map, self);
    }

    public GetGroupOrgByCidResponseBody setGroupOrganization(Long groupOrganization) {
        this.groupOrganization = groupOrganization;
        return this;
    }
    public Long getGroupOrganization() {
        return this.groupOrganization;
    }

}
