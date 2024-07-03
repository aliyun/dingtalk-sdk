// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupRoleAddResponseBody extends TeaModel {
    @NameInMap("result")
    public OpenGroupRoleAddResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static OpenGroupRoleAddResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupRoleAddResponseBody self = new OpenGroupRoleAddResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenGroupRoleAddResponseBody setResult(OpenGroupRoleAddResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public OpenGroupRoleAddResponseBodyResult getResult() {
        return this.result;
    }

    public OpenGroupRoleAddResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class OpenGroupRoleAddResponseBodyResult extends TeaModel {
        @NameInMap("openRoleId")
        public String openRoleId;

        public static OpenGroupRoleAddResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            OpenGroupRoleAddResponseBodyResult self = new OpenGroupRoleAddResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public OpenGroupRoleAddResponseBodyResult setOpenRoleId(String openRoleId) {
            this.openRoleId = openRoleId;
            return this;
        }
        public String getOpenRoleId() {
            return this.openRoleId;
        }

    }

}
