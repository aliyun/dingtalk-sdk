// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class RecallOfficialAccountOTOMessageRequest extends TeaModel {
    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 帐号ID 可空
    @NameInMap("accountId")
    public String accountId;

    // 消息推送时返回的ID
    @NameInMap("openPushId")
    public String openPushId;

    public static RecallOfficialAccountOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        RecallOfficialAccountOTOMessageRequest self = new RecallOfficialAccountOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public RecallOfficialAccountOTOMessageRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public RecallOfficialAccountOTOMessageRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public RecallOfficialAccountOTOMessageRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public RecallOfficialAccountOTOMessageRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
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
