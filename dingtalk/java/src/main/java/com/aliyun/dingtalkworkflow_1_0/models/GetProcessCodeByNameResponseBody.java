// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessCodeByNameResponseBody extends TeaModel {
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
        /**
         * <p>This parameter is required.</p>
         * <br>
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("processCode")
        public String processCode;

        public static GetProcessCodeByNameResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProcessCodeByNameResponseBodyResult self = new GetProcessCodeByNameResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProcessCodeByNameResponseBodyResult setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
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
