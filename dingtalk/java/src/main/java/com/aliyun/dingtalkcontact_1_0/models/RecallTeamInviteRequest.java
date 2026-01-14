// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class RecallTeamInviteRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>13336082715</p>
     */
    @NameInMap("mobile")
    public String mobile;

    @NameInMap("optUserId")
    public String optUserId;

    public static RecallTeamInviteRequest build(java.util.Map<String, ?> map) throws Exception {
        RecallTeamInviteRequest self = new RecallTeamInviteRequest();
        return TeaModel.build(map, self);
    }

    public RecallTeamInviteRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public RecallTeamInviteRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

}
