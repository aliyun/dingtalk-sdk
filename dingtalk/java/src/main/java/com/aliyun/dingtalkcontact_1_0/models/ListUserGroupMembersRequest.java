// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListUserGroupMembersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupCode")
    public String groupCode;

    @NameInMap("offset")
    public Long offset;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("size")
    public Integer size;

    public static ListUserGroupMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListUserGroupMembersRequest self = new ListUserGroupMembersRequest();
        return TeaModel.build(map, self);
    }

    public ListUserGroupMembersRequest setGroupCode(String groupCode) {
        this.groupCode = groupCode;
        return this;
    }
    public String getGroupCode() {
        return this.groupCode;
    }

    public ListUserGroupMembersRequest setOffset(Long offset) {
        this.offset = offset;
        return this;
    }
    public Long getOffset() {
        return this.offset;
    }

    public ListUserGroupMembersRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

}
