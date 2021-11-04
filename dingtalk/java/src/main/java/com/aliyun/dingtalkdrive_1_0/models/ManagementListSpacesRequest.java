// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementListSpacesRequest extends TeaModel {
    // 空间id列表
    @NameInMap("spaceIds")
    public java.util.List<String> spaceIds;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static ManagementListSpacesRequest build(java.util.Map<String, ?> map) throws Exception {
        ManagementListSpacesRequest self = new ManagementListSpacesRequest();
        return TeaModel.build(map, self);
    }

    public ManagementListSpacesRequest setSpaceIds(java.util.List<String> spaceIds) {
        this.spaceIds = spaceIds;
        return this;
    }
    public java.util.List<String> getSpaceIds() {
        return this.spaceIds;
    }

    public ManagementListSpacesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
