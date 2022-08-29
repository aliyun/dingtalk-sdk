// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessCodeByNameResponseBody extends TeaModel {
    // 表单模板信息
    @NameInMap("result")
    public GetProcessCodeByNameResponseBodyResult result;

    public static GetProcessCodeByNameResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProcessCodeByNameResponseBody self = new GetProcessCodeByNameResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProcessCodeByNameResponseBody setResult(GetProcessCodeByNameResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetProcessCodeByNameResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetProcessCodeByNameResponseBodyResult extends TeaModel {
        // 保存或更新的表单code
        @NameInMap("processCode")
        public String processCode;

        public static GetProcessCodeByNameResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProcessCodeByNameResponseBodyResult self = new GetProcessCodeByNameResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProcessCodeByNameResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
