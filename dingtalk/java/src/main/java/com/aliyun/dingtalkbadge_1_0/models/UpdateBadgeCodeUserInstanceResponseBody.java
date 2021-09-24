// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class UpdateBadgeCodeUserInstanceResponseBody extends TeaModel {
    // 码ID
    @NameInMap("codeId")
    public String codeId;

    public static UpdateBadgeCodeUserInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateBadgeCodeUserInstanceResponseBody self = new UpdateBadgeCodeUserInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateBadgeCodeUserInstanceResponseBody setCodeId(String codeId) {
        this.codeId = codeId;
        return this;
    }
    public String getCodeId() {
        return this.codeId;
    }

}
