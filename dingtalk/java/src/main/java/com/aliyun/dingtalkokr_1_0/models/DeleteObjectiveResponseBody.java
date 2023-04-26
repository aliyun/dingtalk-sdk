// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class DeleteObjectiveResponseBody extends TeaModel {
    @NameInMap("data")
    public DeleteObjectiveResponseBodyData data;

    @NameInMap("success")
    public Boolean success;

    public static DeleteObjectiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteObjectiveResponseBody self = new DeleteObjectiveResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteObjectiveResponseBody setData(DeleteObjectiveResponseBodyData data) {
        this.data = data;
        return this;
    }
    public DeleteObjectiveResponseBodyData getData() {
        return this.data;
    }

    public DeleteObjectiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DeleteObjectiveResponseBodyData extends TeaModel {
        @NameInMap("id")
        public String id;

        public static DeleteObjectiveResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            DeleteObjectiveResponseBodyData self = new DeleteObjectiveResponseBodyData();
            return TeaModel.build(map, self);
        }

        public DeleteObjectiveResponseBodyData setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
