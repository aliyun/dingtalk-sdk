// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListIndustryRoleUsersResponseBody extends TeaModel {
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static ListIndustryRoleUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListIndustryRoleUsersResponseBody self = new ListIndustryRoleUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListIndustryRoleUsersResponseBody setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
