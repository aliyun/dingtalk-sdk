// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupAddResponseBody extends TeaModel {
    @NameInMap("result")
    public GroupAddResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GroupAddResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupAddResponseBody self = new GroupAddResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupAddResponseBody setResult(GroupAddResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GroupAddResponseBodyResult getResult() {
        return this.result;
    }

    public GroupAddResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GroupAddResponseBodyResult extends TeaModel {
        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        public static GroupAddResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GroupAddResponseBodyResult self = new GroupAddResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GroupAddResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GroupAddResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
