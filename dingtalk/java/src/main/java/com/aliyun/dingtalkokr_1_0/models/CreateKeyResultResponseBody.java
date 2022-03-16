// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateKeyResultResponseBody extends TeaModel {
    @NameInMap("data")
    public CreateKeyResultResponseBodyData data;

    // 请求成功的标识。
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
        // 创建成功的 KR ID。
        @NameInMap("id")
        public java.io.InputStream id;

        // KR的位置。
        @NameInMap("position")
        public Long position;

        // KR 的权重。
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
