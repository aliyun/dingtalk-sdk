// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateKeyResultResponseBody extends TeaModel {
    @NameInMap("data")
    public CreateKeyResultResponseBodyData data;

    @NameInMap("success")
    public Boolean success;

    public static CreateKeyResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateKeyResultResponseBody self = new CreateKeyResultResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateKeyResultResponseBody setData(CreateKeyResultResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CreateKeyResultResponseBodyData getData() {
        return this.data;
    }

    public CreateKeyResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateKeyResultResponseBodyData extends TeaModel {
        @NameInMap("id")
        public java.io.InputStream id;

        @NameInMap("position")
        public Long position;

        @NameInMap("weight")
        public Long weight;

        public static CreateKeyResultResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CreateKeyResultResponseBodyData self = new CreateKeyResultResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CreateKeyResultResponseBodyData setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public CreateKeyResultResponseBodyData setPosition(Long position) {
            this.position = position;
            return this;
        }
        public Long getPosition() {
            return this.position;
        }

        public CreateKeyResultResponseBodyData setWeight(Long weight) {
            this.weight = weight;
            return this;
        }
        public Long getWeight() {
            return this.weight;
        }

    }

}
