// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreGroupInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    public static DigitalStoreGroupInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreGroupInfoRequest self = new DigitalStoreGroupInfoRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreGroupInfoRequest setGroupId(Long groupId) {
        this.groupId = groupId;
        return this;
    }
    public Long getGroupId() {
        return this.groupId;
    }

}
