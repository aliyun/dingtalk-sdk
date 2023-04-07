// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupUpdateResponseBody extends TeaModel {
    @NameInMap("result")
    public GroupUpdateResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GroupUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupUpdateResponseBody self = new GroupUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupUpdateResponseBody setResult(GroupUpdateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GroupUpdateResponseBodyResult getResult() {
        return this.result;
    }

    public GroupUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GroupUpdateResponseBodyResult extends TeaModel {
        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        public static GroupUpdateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GroupUpdateResponseBodyResult self = new GroupUpdateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GroupUpdateResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GroupUpdateResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
