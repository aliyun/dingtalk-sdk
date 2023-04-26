// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetMigrationUnionIdByUnionIdResponseBody extends TeaModel {
    @NameInMap("migrationUnionIdList")
    public java.util.Map<String, ?> migrationUnionIdList;

    public static GetMigrationUnionIdByUnionIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMigrationUnionIdByUnionIdResponseBody self = new GetMigrationUnionIdByUnionIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMigrationUnionIdByUnionIdResponseBody setMigrationUnionIdList(java.util.Map<String, ?> migrationUnionIdList) {
        this.migrationUnionIdList = migrationUnionIdList;
        return this;
    }
    public java.util.Map<String, ?> getMigrationUnionIdList() {
        return this.migrationUnionIdList;
    }

}
