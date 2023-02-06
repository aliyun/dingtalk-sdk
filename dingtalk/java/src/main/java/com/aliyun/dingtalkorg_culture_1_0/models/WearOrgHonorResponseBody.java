// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class WearOrgHonorResponseBody extends TeaModel {
    @NameInMap("result")
    public WearOrgHonorResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static WearOrgHonorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WearOrgHonorResponseBody self = new WearOrgHonorResponseBody();
        return TeaModel.build(map, self);
    }

    public WearOrgHonorResponseBody setResult(WearOrgHonorResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public WearOrgHonorResponseBodyResult getResult() {
        return this.result;
    }

    public WearOrgHonorResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class WearOrgHonorResponseBodyResult extends TeaModel {
        @NameInMap("honorId")
        public String honorId;

        public static WearOrgHonorResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            WearOrgHonorResponseBodyResult self = new WearOrgHonorResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public WearOrgHonorResponseBodyResult setHonorId(String honorId) {
            this.honorId = honorId;
            return this;
        }
        public String getHonorId() {
            return this.honorId;
        }

    }

}
