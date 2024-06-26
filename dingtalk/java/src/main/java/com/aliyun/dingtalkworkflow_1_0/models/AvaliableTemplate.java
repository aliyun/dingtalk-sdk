// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class AvaliableTemplate extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>出差申请</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-abcd</p>
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
