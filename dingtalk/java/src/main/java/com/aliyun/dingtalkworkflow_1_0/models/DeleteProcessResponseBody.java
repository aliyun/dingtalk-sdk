// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class DeleteProcessResponseBody extends TeaModel {
    @NameInMap("result")
    public DeleteProcessResponseBodyResult result;

    public static DeleteProcessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteProcessResponseBody self = new DeleteProcessResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteProcessResponseBody setResult(DeleteProcessResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DeleteProcessResponseBodyResult getResult() {
        return this.result;
    }

    public static class DeleteProcessResponseBodyResult extends TeaModel {
        // 模板code
        @NameInMap("processCode")
        public String processCode;

        public static DeleteProcessResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DeleteProcessResponseBodyResult self = new DeleteProcessResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DeleteProcessResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
