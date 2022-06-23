// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class DeleteWaterMarkTemplateResponseBody extends TeaModel {
    // 模板的表单Code。
    @NameInMap("result")
    public String result;

    public static DeleteWaterMarkTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteWaterMarkTemplateResponseBody self = new DeleteWaterMarkTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteWaterMarkTemplateResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
