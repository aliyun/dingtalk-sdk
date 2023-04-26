// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessCodeByNameRequest extends TeaModel {
    @NameInMap("name")
    public String name;

    public static GetProcessCodeByNameRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProcessCodeByNameRequest self = new GetProcessCodeByNameRequest();
        return TeaModel.build(map, self);
    }

    public GetProcessCodeByNameRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
