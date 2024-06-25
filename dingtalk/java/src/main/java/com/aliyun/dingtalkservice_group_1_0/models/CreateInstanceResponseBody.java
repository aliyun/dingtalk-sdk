// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateInstanceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>8888***</p>
     */
    @NameInMap("openDataInstanceId")
    public String openDataInstanceId;

    public static CreateInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateInstanceResponseBody self = new CreateInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateInstanceResponseBody setOpenDataInstanceId(String openDataInstanceId) {
        this.openDataInstanceId = openDataInstanceId;
        return this;
    }
    public String getOpenDataInstanceId() {
        return this.openDataInstanceId;
    }

}
