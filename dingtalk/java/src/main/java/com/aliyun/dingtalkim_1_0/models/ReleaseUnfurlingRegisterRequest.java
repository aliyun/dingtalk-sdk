// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ReleaseUnfurlingRegisterRequest extends TeaModel {
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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>37xxxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ReleaseUnfurlingRegisterRequest build(java.util.Map<String, ?> map) throws Exception {
        ReleaseUnfurlingRegisterRequest self = new ReleaseUnfurlingRegisterRequest();
        return TeaModel.build(map, self);
    }

    public ReleaseUnfurlingRegisterRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public ReleaseUnfurlingRegisterRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public ReleaseUnfurlingRegisterRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
