// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class CreateOrgHonorResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateOrgHonorResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateOrgHonorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateOrgHonorResponseBody self = new CreateOrgHonorResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateOrgHonorResponseBody setResult(CreateOrgHonorResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateOrgHonorResponseBodyResult getResult() {
        return this.result;
    }

    public CreateOrgHonorResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateOrgHonorResponseBodyResult extends TeaModel {
        @NameInMap("honorId")
        public String honorId;

        public static CreateOrgHonorResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateOrgHonorResponseBodyResult self = new CreateOrgHonorResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateOrgHonorResponseBodyResult setHonorId(String honorId) {
            this.honorId = honorId;
            return this;
        }
        public String getHonorId() {
            return this.honorId;
        }

    }

}
