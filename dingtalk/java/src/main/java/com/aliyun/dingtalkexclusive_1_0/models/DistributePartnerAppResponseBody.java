// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DistributePartnerAppResponseBody extends TeaModel {
    /**
     * <p>安装邀请链接</p>
     */
    @NameInMap("inviteUrl")
    public String inviteUrl;

    public static DistributePartnerAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DistributePartnerAppResponseBody self = new DistributePartnerAppResponseBody();
        return TeaModel.build(map, self);
    }

    public DistributePartnerAppResponseBody setInviteUrl(String inviteUrl) {
        this.inviteUrl = inviteUrl;
        return this;
    }
    public String getInviteUrl() {
        return this.inviteUrl;
    }

}
