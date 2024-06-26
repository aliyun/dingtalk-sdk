// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementModifySpaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("quota")
    public Long quota;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaceIds")
    public java.util.List<String> spaceIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ManagementModifySpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        ManagementModifySpaceRequest self = new ManagementModifySpaceRequest();
        return TeaModel.build(map, self);
    }

    public ManagementModifySpaceRequest setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

    public ManagementModifySpaceRequest setSpaceIds(java.util.List<String> spaceIds) {
        this.spaceIds = spaceIds;
        return this;
    }
    public java.util.List<String> getSpaceIds() {
        return this.spaceIds;
    }

    public ManagementModifySpaceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
