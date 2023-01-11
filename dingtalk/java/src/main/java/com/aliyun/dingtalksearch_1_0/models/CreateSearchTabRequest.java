// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class CreateSearchTabRequest extends TeaModel {
    /**
     * <p>数据源名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>数据源优先级，数值越小优先级越高</p>
     */
    @NameInMap("priority")
    public Integer priority;

    /**
     * <p>数据来源,非必填,默认来源为钉钉搜索内部引擎</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <p>数据源状态，1表示上线，0表示下线</p>
     */
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

    public CreateSearchTabRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public CreateSearchTabRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
