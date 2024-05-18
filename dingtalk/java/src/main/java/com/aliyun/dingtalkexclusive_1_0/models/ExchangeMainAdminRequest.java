// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExchangeMainAdminRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("newAdminUserId")
    public String newAdminUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("oldAdminUserId")
    public String oldAdminUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static ExchangeMainAdminRequest build(java.util.Map<String, ?> map) throws Exception {
        ExchangeMainAdminRequest self = new ExchangeMainAdminRequest();
        return TeaModel.build(map, self);
    }

    public ExchangeMainAdminRequest setNewAdminUserId(String newAdminUserId) {
        this.newAdminUserId = newAdminUserId;
        return this;
    }
    public String getNewAdminUserId() {
        return this.newAdminUserId;
    }

    public ExchangeMainAdminRequest setOldAdminUserId(String oldAdminUserId) {
        this.oldAdminUserId = oldAdminUserId;
        return this;
    }
    public String getOldAdminUserId() {
        return this.oldAdminUserId;
    }

    public ExchangeMainAdminRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
