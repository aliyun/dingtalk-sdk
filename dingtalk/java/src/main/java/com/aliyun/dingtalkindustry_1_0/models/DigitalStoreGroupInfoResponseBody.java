// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreGroupInfoResponseBody extends TeaModel {
    /**
     * <p>分组Id</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    /**
     * <p>分组名称</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>分组中门店Id列表</p>
     */
    @NameInMap("storeIdList")
    public java.util.List<Long> storeIdList;

    public static DigitalStoreGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreGroupInfoResponseBody self = new DigitalStoreGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreGroupInfoResponseBody setGroupId(Long groupId) {
        this.groupId = groupId;
        return this;
    }
    public Long getGroupId() {
        return this.groupId;
    }

    public DigitalStoreGroupInfoResponseBody setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public DigitalStoreGroupInfoResponseBody setStoreIdList(java.util.List<Long> storeIdList) {
        this.storeIdList = storeIdList;
        return this;
    }
    public java.util.List<Long> getStoreIdList() {
        return this.storeIdList;
    }

}
