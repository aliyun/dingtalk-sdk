// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomGroupRoleResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateCustomGroupRoleResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateCustomGroupRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomGroupRoleResponseBody self = new CreateCustomGroupRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCustomGroupRoleResponseBody setResult(CreateCustomGroupRoleResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateCustomGroupRoleResponseBodyResult getResult() {
        return this.result;
    }

    public CreateCustomGroupRoleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateCustomGroupRoleResponseBodyResult extends TeaModel {
        @NameInMap("openRoleId")
        public String openRoleId;

        public static CreateCustomGroupRoleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomGroupRoleResponseBodyResult self = new CreateCustomGroupRoleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateCustomGroupRoleResponseBodyResult setOpenRoleId(String openRoleId) {
            this.openRoleId = openRoleId;
            return this;
        }
        public String getOpenRoleId() {
            return this.openRoleId;
        }

    }

}
