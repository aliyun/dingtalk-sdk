// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountOTOMessageResultRequest extends TeaModel {
    // 推送ID
    @NameInMap("openPushId")
    public String openPushId;

    @NameInMap("accountId")
    public String accountId;

    public static GetOfficialAccountOTOMessageResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountOTOMessageResultRequest self = new GetOfficialAccountOTOMessageResultRequest();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountOTOMessageResultRequest setOpenPushId(String openPushId) {
        this.openPushId = openPushId;
        return this;
    }
    public String getOpenPushId() {
        return this.openPushId;
    }

    public GetOfficialAccountOTOMessageResultRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

}
