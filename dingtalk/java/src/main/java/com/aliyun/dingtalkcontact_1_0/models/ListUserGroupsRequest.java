// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListUserGroupsRequest extends TeaModel {
    @NameInMap("groupType")
    public String groupType;

    @NameInMap("offset")
    public Long offset;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("size")
    public Integer size;

    public static ListUserGroupsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListUserGroupsRequest self = new ListUserGroupsRequest();
        return TeaModel.build(map, self);
    }

    public ListUserGroupsRequest setGroupType(String groupType) {
        this.groupType = groupType;
        return this;
    }
    public String getGroupType() {
        return this.groupType;
    }

    public ListUserGroupsRequest setOffset(Long offset) {
        this.offset = offset;
        return this;
    }
    public Long getOffset() {
        return this.offset;
    }

    public ListUserGroupsRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

}
