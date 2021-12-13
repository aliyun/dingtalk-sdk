// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetAppsRequest extends TeaModel {
    // 查询类型。All=全部，Solution=以解决方案编码为条件来查询应用，AppCode=以应用编码为条件来查询
    @NameInMap("queryType")
    public String queryType;

    // 待查询的编码数组。queryType参数为All时，此值可为空
    @NameInMap("values")
    public java.util.List<String> values;

    public static GetAppsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAppsRequest self = new GetAppsRequest();
        return TeaModel.build(map, self);
    }

    public GetAppsRequest setQueryType(String queryType) {
        this.queryType = queryType;
        return this;
    }
    public String getQueryType() {
        return this.queryType;
    }

    public GetAppsRequest setValues(java.util.List<String> values) {
        this.values = values;
        return this;
    }
    public java.util.List<String> getValues() {
        return this.values;
    }

}
