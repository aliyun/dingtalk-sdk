// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSimpleUsersByRoleRequest extends TeaModel {
    // cursor
    @NameInMap("offset")
    public Long offset;

    // size
    @NameInMap("size")
    public Integer size;

    // roleId
    @NameInMap("roleId")
    public Long roleId;

    // subCorpId
    @NameInMap("subCorpId")
    public String subCorpId;

    public static ListSimpleUsersByRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSimpleUsersByRoleRequest self = new ListSimpleUsersByRoleRequest();
        return TeaModel.build(map, self);
    }

    public ListSimpleUsersByRoleRequest setOffset(Long offset) {
        this.offset = offset;
        return this;
    }
    public Long getOffset() {
        return this.offset;
    }

    public ListSimpleUsersByRoleRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public ListSimpleUsersByRoleRequest setRoleId(Long roleId) {
        this.roleId = roleId;
        return this;
    }
    public Long getRoleId() {
        return this.roleId;
    }

    public ListSimpleUsersByRoleRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
