// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetMigrationDingIdByDingIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dingId")
    public String dingId;

    public static GetMigrationDingIdByDingIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMigrationDingIdByDingIdRequest self = new GetMigrationDingIdByDingIdRequest();
        return TeaModel.build(map, self);
    }

    public GetMigrationDingIdByDingIdRequest setDingId(String dingId) {
        this.dingId = dingId;
        return this;
    }
    public String getDingId() {
        return this.dingId;
    }

}
