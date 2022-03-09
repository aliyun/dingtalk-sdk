// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateObjectiveResponseBody extends TeaModel {
    // code
    @NameInMap("code")
    public Long code;

    // data
    @NameInMap("data")
    public CreateObjectiveResponseBodyData data;

    // message
    @NameInMap("message")
    public String message;

    // success
    @NameInMap("success")
    public Boolean success;

    public static CreateObjectiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateObjectiveResponseBody self = new CreateObjectiveResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateObjectiveResponseBody setCode(Long code) {
        this.code = code;
        return this;
    }
    public Long getCode() {
        return this.code;
    }

    public CreateObjectiveResponseBody setData(CreateObjectiveResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CreateObjectiveResponseBodyData getData() {
        return this.data;
    }

    public CreateObjectiveResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public CreateObjectiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateObjectiveResponseBodyData extends TeaModel {
        @NameInMap("id")
        public String id;

        public static CreateObjectiveResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CreateObjectiveResponseBodyData self = new CreateObjectiveResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CreateObjectiveResponseBodyData setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
