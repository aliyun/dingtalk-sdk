// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetMigrationUnionIdByUnionIdResponseBody extends TeaModel {
    // migrationUnionId
    @NameInMap("migrationUnionId")
    public String migrationUnionId;

    public static GetMigrationUnionIdByUnionIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMigrationUnionIdByUnionIdResponseBody self = new GetMigrationUnionIdByUnionIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMigrationUnionIdByUnionIdResponseBody setMigrationUnionId(String migrationUnionId) {
        this.migrationUnionId = migrationUnionId;
        return this;
    }
    public String getMigrationUnionId() {
        return this.migrationUnionId;
    }

}
