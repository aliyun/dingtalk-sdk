// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetJobPositionRequest extends TeaModel {
    @NameInMap("jobPositionCode")
    public String jobPositionCode;

    public static GetJobPositionRequest build(java.util.Map<String, ?> map) throws Exception {
        GetJobPositionRequest self = new GetJobPositionRequest();
        return TeaModel.build(map, self);
    }

    public GetJobPositionRequest setJobPositionCode(String jobPositionCode) {
        this.jobPositionCode = jobPositionCode;
        return this;
    }
    public String getJobPositionCode() {
        return this.jobPositionCode;
    }

}
