// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ChangeMainOrgRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>corpIdCCC</p>
     */
    @NameInMap("newMainCorpId")
    public String newMainCorpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>userIdAA</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ChangeMainOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        ChangeMainOrgRequest self = new ChangeMainOrgRequest();
        return TeaModel.build(map, self);
    }

    public ChangeMainOrgRequest setNewMainCorpId(String newMainCorpId) {
        this.newMainCorpId = newMainCorpId;
        return this;
    }
    public String getNewMainCorpId() {
        return this.newMainCorpId;
    }

    public ChangeMainOrgRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
