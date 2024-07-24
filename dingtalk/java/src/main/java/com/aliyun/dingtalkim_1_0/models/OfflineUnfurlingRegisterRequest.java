// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OfflineUnfurlingRegisterRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3102xxxxxxx</p>
     */
    @NameInMap("appId")
    public String appId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <strong>example:</strong>
     * <p>37xxxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static OfflineUnfurlingRegisterRequest build(java.util.Map<String, ?> map) throws Exception {
        OfflineUnfurlingRegisterRequest self = new OfflineUnfurlingRegisterRequest();
        return TeaModel.build(map, self);
    }

    public OfflineUnfurlingRegisterRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public OfflineUnfurlingRegisterRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public OfflineUnfurlingRegisterRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
