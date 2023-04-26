// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUserInfoResponseBody extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("roleIdList")
    public java.util.List<Long> roleIdList;

    @NameInMap("scopeList")
    public java.util.List<Long> scopeList;

    @NameInMap("storeList")
    public java.util.List<Long> storeList;

    @NameInMap("userId")
    public String userId;

    public static DigitalStoreUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreUserInfoResponseBody self = new DigitalStoreUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreUserInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DigitalStoreUserInfoResponseBody setRoleIdList(java.util.List<Long> roleIdList) {
        this.roleIdList = roleIdList;
        return this;
    }
    public java.util.List<Long> getRoleIdList() {
        return this.roleIdList;
    }

    public DigitalStoreUserInfoResponseBody setScopeList(java.util.List<Long> scopeList) {
        this.scopeList = scopeList;
        return this;
    }
    public java.util.List<Long> getScopeList() {
        return this.scopeList;
    }

    public DigitalStoreUserInfoResponseBody setStoreList(java.util.List<Long> storeList) {
        this.storeList = storeList;
        return this;
    }
    public java.util.List<Long> getStoreList() {
        return this.storeList;
    }

    public DigitalStoreUserInfoResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
