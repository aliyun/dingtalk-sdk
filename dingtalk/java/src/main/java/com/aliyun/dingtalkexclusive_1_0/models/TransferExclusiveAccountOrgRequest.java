// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TransferExclusiveAccountOrgRequest extends TeaModel {
    @NameInMap("isSettingMainOrg")
    public Boolean isSettingMainOrg;

    @NameInMap("targetCorpId")
    public String targetCorpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static TransferExclusiveAccountOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        TransferExclusiveAccountOrgRequest self = new TransferExclusiveAccountOrgRequest();
        return TeaModel.build(map, self);
    }

    public TransferExclusiveAccountOrgRequest setIsSettingMainOrg(Boolean isSettingMainOrg) {
        this.isSettingMainOrg = isSettingMainOrg;
        return this;
    }
    public Boolean getIsSettingMainOrg() {
        return this.isSettingMainOrg;
    }

    public TransferExclusiveAccountOrgRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public TransferExclusiveAccountOrgRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
