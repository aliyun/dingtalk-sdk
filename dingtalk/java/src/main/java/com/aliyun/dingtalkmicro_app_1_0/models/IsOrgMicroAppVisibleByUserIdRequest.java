// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class IsOrgMicroAppVisibleByUserIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appId")
    public Long appId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("type")
    public String type;

    public static IsOrgMicroAppVisibleByUserIdRequest build(java.util.Map<String, ?> map) throws Exception {
        IsOrgMicroAppVisibleByUserIdRequest self = new IsOrgMicroAppVisibleByUserIdRequest();
        return TeaModel.build(map, self);
    }

    public IsOrgMicroAppVisibleByUserIdRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public IsOrgMicroAppVisibleByUserIdRequest setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public IsOrgMicroAppVisibleByUserIdRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
