// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSimpleUsersByRoleRequest extends TeaModel {
    // 起始位置
    @NameInMap("offset")
    public Long offset;

    // 角色ID
    @NameInMap("roleId")
    public Long roleId;

    // 查询数量
    @NameInMap("size")
    public Integer size;

    // 下属组织的组织ID，比如下属镇、村的corpId
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

    public ListSimpleUsersByRoleRequest setRoleId(Long roleId) {
        this.roleId = roleId;
        return this;
    }
    public Long getRoleId() {
        return this.roleId;
    }

    public ListSimpleUsersByRoleRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public ListSimpleUsersByRoleRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
