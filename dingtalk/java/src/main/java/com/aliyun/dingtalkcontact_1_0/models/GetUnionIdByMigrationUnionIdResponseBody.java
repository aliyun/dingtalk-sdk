// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUnionIdByMigrationUnionIdResponseBody extends TeaModel {
    // unionId
    @NameInMap("unionId")
    public String unionId;

    public static GetUnionIdByMigrationUnionIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUnionIdByMigrationUnionIdResponseBody self = new GetUnionIdByMigrationUnionIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUnionIdByMigrationUnionIdResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
