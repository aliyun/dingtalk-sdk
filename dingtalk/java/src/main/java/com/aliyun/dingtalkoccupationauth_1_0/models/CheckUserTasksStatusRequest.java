// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoccupationauth_1_0.models;

import com.aliyun.tea.*;

public class CheckUserTasksStatusRequest extends TeaModel {
    @NameInMap("provinceCode")
    public String provinceCode;

    public static CheckUserTasksStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckUserTasksStatusRequest self = new CheckUserTasksStatusRequest();
        return TeaModel.build(map, self);
    }

    public CheckUserTasksStatusRequest setProvinceCode(String provinceCode) {
        this.provinceCode = provinceCode;
        return this;
    }
    public String getProvinceCode() {
        return this.provinceCode;
    }

}
