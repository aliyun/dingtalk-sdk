// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class CreateSearchTabRequest extends TeaModel {
    // 数据源名称
    @NameInMap("name")
    public String name;

    // 数据源优先级，数值越大优先级越高
    @NameInMap("priority")
    public Integer priority;

    // 数据源状态，1表示上线，0表示下线
    @NameInMap("status")
    public Integer status;

    public static CreateSearchTabRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSearchTabRequest self = new CreateSearchTabRequest();
        return TeaModel.build(map, self);
    }

    public CreateSearchTabRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateSearchTabRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public CreateSearchTabRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
