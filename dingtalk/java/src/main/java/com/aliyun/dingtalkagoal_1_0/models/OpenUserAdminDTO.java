// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenUserAdminDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dingCorpId")
    public String dingCorpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dingUserId")
    public String dingUserId;

    public static OpenUserAdminDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenUserAdminDTO self = new OpenUserAdminDTO();
        return TeaModel.build(map, self);
    }

    public OpenUserAdminDTO setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public OpenUserAdminDTO setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

}
