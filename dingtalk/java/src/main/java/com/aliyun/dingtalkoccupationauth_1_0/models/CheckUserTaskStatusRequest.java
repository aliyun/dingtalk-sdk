// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoccupationauth_1_0.models;

import com.aliyun.tea.*;

public class CheckUserTaskStatusRequest extends TeaModel {
    @NameInMap("provinceCode")
    public String provinceCode;

    public static CheckUserTaskStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckUserTaskStatusRequest self = new CheckUserTaskStatusRequest();
        return TeaModel.build(map, self);
    }

    public CheckUserTaskStatusRequest setProvinceCode(String provinceCode) {
        this.provinceCode = provinceCode;
        return this;
    }
    public String getProvinceCode() {
        return this.provinceCode;
    }

}
