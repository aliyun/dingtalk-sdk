// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListUserIndustryRolesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ListUserIndustryRolesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListUserIndustryRolesRequest self = new ListUserIndustryRolesRequest();
        return TeaModel.build(map, self);
    }

    public ListUserIndustryRolesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
