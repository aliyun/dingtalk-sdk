// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetMigrationDingIdByDingIdResponseBody extends TeaModel {
    // migrationDingIdList
    @NameInMap("migrationDingIdList")
    public java.util.Map<String, ?> migrationDingIdList;

    public static GetMigrationDingIdByDingIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMigrationDingIdByDingIdResponseBody self = new GetMigrationDingIdByDingIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMigrationDingIdByDingIdResponseBody setMigrationDingIdList(java.util.Map<String, ?> migrationDingIdList) {
        this.migrationDingIdList = migrationDingIdList;
        return this;
    }
    public java.util.Map<String, ?> getMigrationDingIdList() {
        return this.migrationDingIdList;
    }

}
