// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteDeptInfoRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteDeptInfoRequestParams> params;

    public static HrbrainDeleteDeptInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteDeptInfoRequest self = new HrbrainDeleteDeptInfoRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteDeptInfoRequest setParams(java.util.List<HrbrainDeleteDeptInfoRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteDeptInfoRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteDeptInfoRequestParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deptNo")
        public String deptNo;

        public static HrbrainDeleteDeptInfoRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteDeptInfoRequestParams self = new HrbrainDeleteDeptInfoRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteDeptInfoRequestParams setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

    }

}
