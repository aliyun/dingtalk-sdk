// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CopyProcessResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<CopyProcessResponseBodyResult> result;

    public static CopyProcessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CopyProcessResponseBody self = new CopyProcessResponseBody();
        return TeaModel.build(map, self);
    }

    public CopyProcessResponseBody setResult(java.util.List<CopyProcessResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<CopyProcessResponseBodyResult> getResult() {
        return this.result;
    }

    public static class CopyProcessResponseBodyResult extends TeaModel {
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("name")
        public String name;

        @NameInMap("processCode")
        public String processCode;

        public static CopyProcessResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CopyProcessResponseBodyResult self = new CopyProcessResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CopyProcessResponseBodyResult setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public CopyProcessResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CopyProcessResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
