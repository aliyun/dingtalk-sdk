// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class InstallAppResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<InstallAppResponseBodyResult> result;

    public static InstallAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InstallAppResponseBody self = new InstallAppResponseBody();
        return TeaModel.build(map, self);
    }

    public InstallAppResponseBody setResult(java.util.List<InstallAppResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<InstallAppResponseBodyResult> getResult() {
        return this.result;
    }

    public static class InstallAppResponseBodyResult extends TeaModel {
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("name")
        public String name;

        @NameInMap("processCode")
        public String processCode;

        public static InstallAppResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            InstallAppResponseBodyResult self = new InstallAppResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public InstallAppResponseBodyResult setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public InstallAppResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public InstallAppResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
