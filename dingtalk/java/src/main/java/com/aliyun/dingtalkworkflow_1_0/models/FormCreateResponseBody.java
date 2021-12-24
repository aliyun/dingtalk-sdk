// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormCreateResponseBody extends TeaModel {
    // 表单模板信息
    @NameInMap("result")
    public FormCreateResponseBodyResult result;

    public static FormCreateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FormCreateResponseBody self = new FormCreateResponseBody();
        return TeaModel.build(map, self);
    }

    public FormCreateResponseBody setResult(FormCreateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public FormCreateResponseBodyResult getResult() {
        return this.result;
    }

    public static class FormCreateResponseBodyResult extends TeaModel {
        // 保存或更新的表单code
        @NameInMap("processCode")
        public String processCode;

        public static FormCreateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            FormCreateResponseBodyResult self = new FormCreateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public FormCreateResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
