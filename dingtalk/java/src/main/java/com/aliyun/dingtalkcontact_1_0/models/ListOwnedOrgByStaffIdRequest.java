// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListOwnedOrgByStaffIdRequest extends TeaModel {
    // userId
    @NameInMap("userId")
    public String userId;

    public static ListOwnedOrgByStaffIdRequest build(java.util.Map<String, ?> map) throws Exception {
        ListOwnedOrgByStaffIdRequest self = new ListOwnedOrgByStaffIdRequest();
        return TeaModel.build(map, self);
    }

    public ListOwnedOrgByStaffIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
