// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class UpdateSearchTabRequest extends TeaModel {
    // 数据源名称
    @NameInMap("name")
    public String name;

    // 数据源优先级，数值越小优先级越高
    @NameInMap("priority")
    public Integer priority;

    // 数据来源,非必填,默认来源为钉钉搜索内部引擎
    @NameInMap("source")
    public String source;

    // 数据源状态，1表示上线，0表示下线
    @NameInMap("status")
    public Integer status;

    public static UpdateSearchTabRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateSearchTabRequest self = new UpdateSearchTabRequest();
        return TeaModel.build(map, self);
    }

    public UpdateSearchTabRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateSearchTabRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public UpdateSearchTabRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public UpdateSearchTabRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
