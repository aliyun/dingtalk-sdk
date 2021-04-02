// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class AddCityCarApplyResponseBody extends TeaModel {
    // 商旅内部审批单ID
    @NameInMap("applyId")
    public Long applyId;

    public static AddCityCarApplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCityCarApplyResponseBody self = new AddCityCarApplyResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCityCarApplyResponseBody setApplyId(Long applyId) {
        this.applyId = applyId;
        return this;
    }
    public Long getApplyId() {
        return this.applyId;
    }

}
