// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreGroupInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>分组1</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>This parameter is required.</p>
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
