// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class PersonalSendCardMessageResponseBody extends TeaModel {
    @NameInMap("result")
    public PersonalSendCardMessageResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static PersonalSendCardMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PersonalSendCardMessageResponseBody self = new PersonalSendCardMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public PersonalSendCardMessageResponseBody setResult(PersonalSendCardMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PersonalSendCardMessageResponseBodyResult getResult() {
        return this.result;
    }

    public PersonalSendCardMessageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PersonalSendCardMessageResponseBodyResult extends TeaModel {
        @NameInMap("openTaskId")
        public String openTaskId;

        public static PersonalSendCardMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PersonalSendCardMessageResponseBodyResult self = new PersonalSendCardMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PersonalSendCardMessageResponseBodyResult setOpenTaskId(String openTaskId) {
            this.openTaskId = openTaskId;
            return this;
        }
        public String getOpenTaskId() {
            return this.openTaskId;
        }

    }

}
