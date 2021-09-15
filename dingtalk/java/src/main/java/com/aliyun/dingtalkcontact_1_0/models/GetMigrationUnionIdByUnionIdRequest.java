// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetMigrationUnionIdByUnionIdRequest extends TeaModel {
    // unionId
    @NameInMap("unionId")
    public String unionId;

    public static GetMigrationUnionIdByUnionIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMigrationUnionIdByUnionIdRequest self = new GetMigrationUnionIdByUnionIdRequest();
        return TeaModel.build(map, self);
    }

    public GetMigrationUnionIdByUnionIdRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
