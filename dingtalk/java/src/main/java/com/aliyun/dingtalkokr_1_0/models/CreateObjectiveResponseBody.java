// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateObjectiveResponseBody extends TeaModel {
    // data
    @NameInMap("data")
    public CreateObjectiveResponseBodyData data;

    // 请求成功的标识。
    @NameInMap("success")
    public Boolean success;

    public static CreateObjectiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateObjectiveResponseBody self = new CreateObjectiveResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateObjectiveResponseBody setData(CreateObjectiveResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CreateObjectiveResponseBodyData getData() {
        return this.data;
    }

    public CreateObjectiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateObjectiveResponseBodyData extends TeaModel {
        // 当前 Objective ID。
        @NameInMap("id")
        public String id;

        // 当前 Objective 的位置。
        @NameInMap("position")
        public String position;

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

        public CreateObjectiveResponseBodyData setPosition(String position) {
            this.position = position;
            return this;
        }
        public String getPosition() {
            return this.position;
        }

    }

}
