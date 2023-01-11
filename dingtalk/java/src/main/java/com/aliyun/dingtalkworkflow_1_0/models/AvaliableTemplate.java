// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class AvaliableTemplate extends TeaModel {
    /**
     * <p>表单名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>表单模板processCode</p>
     */
    @NameInMap("processCode")
    public String processCode;

    public static AvaliableTemplate build(java.util.Map<String, ?> map) throws Exception {
        AvaliableTemplate self = new AvaliableTemplate();
        return TeaModel.build(map, self);
    }

    public AvaliableTemplate setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AvaliableTemplate setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

}
