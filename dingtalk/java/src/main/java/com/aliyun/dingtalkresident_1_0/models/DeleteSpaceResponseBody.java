// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class DeleteSpaceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("delFailedDept")
    public java.util.List<DeleteSpaceResponseBodyDelFailedDept> delFailedDept;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("delSuccessCount")
    public Boolean delSuccessCount;

    public static DeleteSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteSpaceResponseBody self = new DeleteSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteSpaceResponseBody setDelFailedDept(java.util.List<DeleteSpaceResponseBodyDelFailedDept> delFailedDept) {
        this.delFailedDept = delFailedDept;
        return this;
    }
    public java.util.List<DeleteSpaceResponseBodyDelFailedDept> getDelFailedDept() {
        return this.delFailedDept;
    }

    public DeleteSpaceResponseBody setDelSuccessCount(Boolean delSuccessCount) {
        this.delSuccessCount = delSuccessCount;
        return this;
    }
    public Boolean getDelSuccessCount() {
        return this.delSuccessCount;
    }

    public static class DeleteSpaceResponseBodyDelFailedDept extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>122222</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        public static DeleteSpaceResponseBodyDelFailedDept build(java.util.Map<String, ?> map) throws Exception {
            DeleteSpaceResponseBodyDelFailedDept self = new DeleteSpaceResponseBodyDelFailedDept();
            return TeaModel.build(map, self);
        }

        public DeleteSpaceResponseBodyDelFailedDept setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

    }

}
