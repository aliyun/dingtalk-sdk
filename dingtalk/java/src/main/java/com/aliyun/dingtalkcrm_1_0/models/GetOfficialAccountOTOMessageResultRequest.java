// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountOTOMessageResultRequest extends TeaModel {
    @NameInMap("accountId")
    public String accountId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openPushId")
    public String openPushId;

    public static GetOfficialAccountOTOMessageResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountOTOMessageResultRequest self = new GetOfficialAccountOTOMessageResultRequest();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountOTOMessageResultRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public GetOfficialAccountOTOMessageResultRequest setOpenPushId(String openPushId) {
        this.openPushId = openPushId;
        return this;
    }
    public String getOpenPushId() {
        return this.openPushId;
    }

}
