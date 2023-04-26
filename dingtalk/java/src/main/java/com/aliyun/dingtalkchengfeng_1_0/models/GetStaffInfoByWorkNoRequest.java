// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetStaffInfoByWorkNoRequest extends TeaModel {
    @NameInMap("workNumbers")
    public String workNumbers;

    public static GetStaffInfoByWorkNoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetStaffInfoByWorkNoRequest self = new GetStaffInfoByWorkNoRequest();
        return TeaModel.build(map, self);
    }

    public GetStaffInfoByWorkNoRequest setWorkNumbers(String workNumbers) {
        this.workNumbers = workNumbers;
        return this;
    }
    public String getWorkNumbers() {
        return this.workNumbers;
    }

}
