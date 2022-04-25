// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessApproveCreateResponseBody extends TeaModel {
    // 审批单返回对象
    @NameInMap("result")
    public ProcessApproveCreateResponseBodyResult result;

    public static ProcessApproveCreateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ProcessApproveCreateResponseBody self = new ProcessApproveCreateResponseBody();
        return TeaModel.build(map, self);
    }

    public ProcessApproveCreateResponseBody setResult(ProcessApproveCreateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ProcessApproveCreateResponseBodyResult getResult() {
        return this.result;
    }

    public static class ProcessApproveCreateResponseBodyResult extends TeaModel {
        // 钉钉侧生成的审批单id
        @NameInMap("dingtalkApproveId")
        public String dingtalkApproveId;

        public static ProcessApproveCreateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ProcessApproveCreateResponseBodyResult self = new ProcessApproveCreateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ProcessApproveCreateResponseBodyResult setDingtalkApproveId(String dingtalkApproveId) {
            this.dingtalkApproveId = dingtalkApproveId;
            return this;
        }
        public String getDingtalkApproveId() {
            return this.dingtalkApproveId;
        }

    }

}
