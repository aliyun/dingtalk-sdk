// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCooperateOrgInviteInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("inviteUrl")
    public String inviteUrl;

    public static GetCooperateOrgInviteInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCooperateOrgInviteInfoResponseBody self = new GetCooperateOrgInviteInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCooperateOrgInviteInfoResponseBody setInviteUrl(String inviteUrl) {
        this.inviteUrl = inviteUrl;
        return this;
    }
    public String getInviteUrl() {
        return this.inviteUrl;
    }

}
