// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveProcessResponseBody extends TeaModel {
    @NameInMap("result")
    public SaveProcessResponseBodyResult result;

    public static SaveProcessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveProcessResponseBody self = new SaveProcessResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveProcessResponseBody setResult(SaveProcessResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SaveProcessResponseBodyResult getResult() {
        return this.result;
    }

    public static class SaveProcessResponseBodyResult extends TeaModel {
        @NameInMap("processCode")
        public String processCode;

        public static SaveProcessResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SaveProcessResponseBodyResult self = new SaveProcessResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SaveProcessResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
