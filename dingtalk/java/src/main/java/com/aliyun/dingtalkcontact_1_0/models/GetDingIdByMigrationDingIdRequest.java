// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetDingIdByMigrationDingIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("migrationDingId")
    public String migrationDingId;

    public static GetDingIdByMigrationDingIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDingIdByMigrationDingIdRequest self = new GetDingIdByMigrationDingIdRequest();
        return TeaModel.build(map, self);
    }

    public GetDingIdByMigrationDingIdRequest setMigrationDingId(String migrationDingId) {
        this.migrationDingId = migrationDingId;
        return this;
    }
    public String getMigrationDingId() {
        return this.migrationDingId;
    }

}
