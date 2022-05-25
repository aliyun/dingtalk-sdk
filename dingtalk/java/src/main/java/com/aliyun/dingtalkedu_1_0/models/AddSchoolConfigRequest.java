// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddSchoolConfigRequest extends TeaModel {
    // 123
    @NameInMap("operatorId")
    public String operatorId;

    // 123
    @NameInMap("operatorName")
    public String operatorName;

    // 3700
    @NameInMap("temperatureUpLimit")
    public Long temperatureUpLimit;

    public static AddSchoolConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        AddSchoolConfigRequest self = new AddSchoolConfigRequest();
        return TeaModel.build(map, self);
    }

    public AddSchoolConfigRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public AddSchoolConfigRequest setOperatorName(String operatorName) {
        this.operatorName = operatorName;
        return this;
    }
    public String getOperatorName() {
        return this.operatorName;
    }

    public AddSchoolConfigRequest setTemperatureUpLimit(Long temperatureUpLimit) {
        this.temperatureUpLimit = temperatureUpLimit;
        return this;
    }
    public Long getTemperatureUpLimit() {
        return this.temperatureUpLimit;
    }

}
