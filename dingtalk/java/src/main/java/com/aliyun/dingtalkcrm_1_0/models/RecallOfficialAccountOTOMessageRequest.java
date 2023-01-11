// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class RecallOfficialAccountOTOMessageRequest extends TeaModel {
    /**
     * <p>帐号ID 可空</p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <p>消息推送时返回的ID</p>
     */
    @NameInMap("openPushId")
    public String openPushId;

    public static RecallOfficialAccountOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        RecallOfficialAccountOTOMessageRequest self = new RecallOfficialAccountOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public RecallOfficialAccountOTOMessageRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public RecallOfficialAccountOTOMessageRequest setOpenPushId(String openPushId) {
        this.openPushId = openPushId;
        return this;
    }
    public String getOpenPushId() {
        return this.openPushId;
    }

}
