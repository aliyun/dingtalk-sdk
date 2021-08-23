// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubDeptResponseBody extends TeaModel {
    // 返回列表
    @NameInMap("result")
    public java.util.List<ListSubDeptResponseBodyResult> result;

    public static ListSubDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSubDeptResponseBody self = new ListSubDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSubDeptResponseBody setResult(java.util.List<ListSubDeptResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListSubDeptResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListSubDeptResponseBodyResult extends TeaModel {
        // 部门ID
        @NameInMap("deptId")
        public Long deptId;

        // 部门名称
        @NameInMap("name")
        public String name;

        public static ListSubDeptResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListSubDeptResponseBodyResult self = new ListSubDeptResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListSubDeptResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public ListSubDeptResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
