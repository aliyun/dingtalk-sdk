// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateDeviceBindingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>bind</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("teamCode")
    public String teamCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateDeviceBindingRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateDeviceBindingRequest self = new UpdateDeviceBindingRequest();
        return TeaModel.build(map, self);
    }

    public UpdateDeviceBindingRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public UpdateDeviceBindingRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public UpdateDeviceBindingRequest setTeamCode(String teamCode) {
        this.teamCode = teamCode;
        return this;
    }
    public String getTeamCode() {
        return this.teamCode;
    }

    public UpdateDeviceBindingRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
