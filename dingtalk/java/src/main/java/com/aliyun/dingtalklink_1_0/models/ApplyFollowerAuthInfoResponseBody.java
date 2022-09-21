// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ApplyFollowerAuthInfoResponseBody extends TeaModel {
    // 推送结果
    @NameInMap("result")
    public ApplyFollowerAuthInfoResponseBodyResult result;

    public static ApplyFollowerAuthInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ApplyFollowerAuthInfoResponseBody self = new ApplyFollowerAuthInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public ApplyFollowerAuthInfoResponseBody setResult(ApplyFollowerAuthInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ApplyFollowerAuthInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class ApplyFollowerAuthInfoResponseBodyResult extends TeaModel {
        // 发送申请ID
        @NameInMap("openApplyId")
        public String openApplyId;

        public static ApplyFollowerAuthInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ApplyFollowerAuthInfoResponseBodyResult self = new ApplyFollowerAuthInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ApplyFollowerAuthInfoResponseBodyResult setOpenApplyId(String openApplyId) {
            this.openApplyId = openApplyId;
            return this;
        }
        public String getOpenApplyId() {
            return this.openApplyId;
        }

    }

}
