// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ControlRecordingRequest extends TeaModel {
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
    @NameInMap("agree")
    public Boolean agree;

    @NameInMap("teamCode")
    public String teamCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ControlRecordingRequest build(java.util.Map<String, ?> map) throws Exception {
        ControlRecordingRequest self = new ControlRecordingRequest();
        return TeaModel.build(map, self);
    }

    public ControlRecordingRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public ControlRecordingRequest setAgree(Boolean agree) {
        this.agree = agree;
        return this;
    }
    public Boolean getAgree() {
        return this.agree;
    }

    public ControlRecordingRequest setTeamCode(String teamCode) {
        this.teamCode = teamCode;
        return this;
    }
    public String getTeamCode() {
        return this.teamCode;
    }

    public ControlRecordingRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
