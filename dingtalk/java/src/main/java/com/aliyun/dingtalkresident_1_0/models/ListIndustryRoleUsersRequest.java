// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListIndustryRoleUsersRequest extends TeaModel {
    // 行业角色编码
    @NameInMap("tagCode")
    public String tagCode;

    public static ListIndustryRoleUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListIndustryRoleUsersRequest self = new ListIndustryRoleUsersRequest();
        return TeaModel.build(map, self);
    }

    public ListIndustryRoleUsersRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

}
