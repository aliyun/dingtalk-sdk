// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class OrgInfoRequest extends TeaModel {
    @NameInMap("orgIds")
    public java.util.List<Long> orgIds;

    public static OrgInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        OrgInfoRequest self = new OrgInfoRequest();
        return TeaModel.build(map, self);
    }

    public OrgInfoRequest setOrgIds(java.util.List<Long> orgIds) {
        this.orgIds = orgIds;
        return this;
    }
    public java.util.List<Long> getOrgIds() {
        return this.orgIds;
    }

}
