// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskStartdateRequest extends TeaModel {
    /**
     * <p>任务开始时间。</p>
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
