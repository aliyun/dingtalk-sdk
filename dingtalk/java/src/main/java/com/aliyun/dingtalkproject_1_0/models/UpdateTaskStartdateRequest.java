// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskStartdateRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2022-07-04T03:29:34.770Z</p>
     */
    @NameInMap("startDate")
    public String startDate;

    public static UpdateTaskStartdateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskStartdateRequest self = new UpdateTaskStartdateRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskStartdateRequest setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

}
