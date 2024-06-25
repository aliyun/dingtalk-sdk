// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ModifyWaterMarkTemplateResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>PROC-292988B1-5064-4A42-9389-A76B97xxxxx</p>
     */
    @NameInMap("result")
    public String result;

    public static ModifyWaterMarkTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ModifyWaterMarkTemplateResponseBody self = new ModifyWaterMarkTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public ModifyWaterMarkTemplateResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
