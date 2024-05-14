// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AddWorkspaceMembersResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("notInOrgList")
    public java.util.List<String> notInOrgList;

    public static AddWorkspaceMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddWorkspaceMembersResponseBody self = new AddWorkspaceMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public AddWorkspaceMembersResponseBody setNotInOrgList(java.util.List<String> notInOrgList) {
        this.notInOrgList = notInOrgList;
        return this;
    }
    public java.util.List<String> getNotInOrgList() {
        return this.notInOrgList;
    }

}
