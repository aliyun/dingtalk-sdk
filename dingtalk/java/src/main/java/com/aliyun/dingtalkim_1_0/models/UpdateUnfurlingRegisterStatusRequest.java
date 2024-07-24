// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateUnfurlingRegisterStatusRequest extends TeaModel {
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
     * <p>2</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <strong>example:</strong>
     * <p>37xxxxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateUnfurlingRegisterStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateUnfurlingRegisterStatusRequest self = new UpdateUnfurlingRegisterStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateUnfurlingRegisterStatusRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public UpdateUnfurlingRegisterStatusRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public UpdateUnfurlingRegisterStatusRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public UpdateUnfurlingRegisterStatusRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
