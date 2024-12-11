// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class GetTaskPackageResultRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskPackageId")
    public String taskPackageId;

    public static GetTaskPackageResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTaskPackageResultRequest self = new GetTaskPackageResultRequest();
        return TeaModel.build(map, self);
    }

    public GetTaskPackageResultRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public GetTaskPackageResultRequest setTaskPackageId(String taskPackageId) {
        this.taskPackageId = taskPackageId;
        return this;
    }
    public String getTaskPackageId() {
        return this.taskPackageId;
    }

}
