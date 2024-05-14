// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUnionIdByMigrationUnionIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("migrationUnionId")
    public String migrationUnionId;

    public static GetUnionIdByMigrationUnionIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUnionIdByMigrationUnionIdRequest self = new GetUnionIdByMigrationUnionIdRequest();
        return TeaModel.build(map, self);
    }

    public GetUnionIdByMigrationUnionIdRequest setMigrationUnionId(String migrationUnionId) {
        this.migrationUnionId = migrationUnionId;
        return this;
    }
    public String getMigrationUnionId() {
        return this.migrationUnionId;
    }

}
