// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetMigrationDingIdByDingIdResponseBody extends TeaModel {
    // migrationDingId
    @NameInMap("migrationDingId")
    public String migrationDingId;

    public static GetMigrationDingIdByDingIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMigrationDingIdByDingIdResponseBody self = new GetMigrationDingIdByDingIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMigrationDingIdByDingIdResponseBody setMigrationDingId(String migrationDingId) {
        this.migrationDingId = migrationDingId;
        return this;
    }
    public String getMigrationDingId() {
        return this.migrationDingId;
    }

}
