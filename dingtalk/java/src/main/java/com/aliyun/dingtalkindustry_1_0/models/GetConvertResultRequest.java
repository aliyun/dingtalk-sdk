// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class GetConvertResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskBizId")
    public String taskBizId;

    public static GetConvertResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetConvertResultRequest self = new GetConvertResultRequest();
        return TeaModel.build(map, self);
    }

    public GetConvertResultRequest setTaskBizId(String taskBizId) {
        this.taskBizId = taskBizId;
        return this;
    }
    public String getTaskBizId() {
        return this.taskBizId;
    }

}
