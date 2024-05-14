// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class RemoveContactFromOrgRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("contactUnionId")
    public String contactUnionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    public static RemoveContactFromOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveContactFromOrgRequest self = new RemoveContactFromOrgRequest();
        return TeaModel.build(map, self);
    }

    public RemoveContactFromOrgRequest setContactUnionId(String contactUnionId) {
        this.contactUnionId = contactUnionId;
        return this;
    }
    public String getContactUnionId() {
        return this.contactUnionId;
    }

    public RemoveContactFromOrgRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
