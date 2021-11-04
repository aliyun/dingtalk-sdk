// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementModifySpaceRequest extends TeaModel {
    // 空间id列表
    @NameInMap("spaceIds")
    public java.util.List<String> spaceIds;

    // 容量
    @NameInMap("quota")
    public Long quota;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static ManagementModifySpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        ManagementModifySpaceRequest self = new ManagementModifySpaceRequest();
        return TeaModel.build(map, self);
    }

    public ManagementModifySpaceRequest setSpaceIds(java.util.List<String> spaceIds) {
        this.spaceIds = spaceIds;
        return this;
    }
    public java.util.List<String> getSpaceIds() {
        return this.spaceIds;
    }

    public ManagementModifySpaceRequest setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

    public ManagementModifySpaceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
