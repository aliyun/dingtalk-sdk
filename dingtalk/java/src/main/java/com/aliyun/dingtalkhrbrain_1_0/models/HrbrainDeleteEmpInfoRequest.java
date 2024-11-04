// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteEmpInfoRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteEmpInfoRequestParams> params;

    public static HrbrainDeleteEmpInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteEmpInfoRequest self = new HrbrainDeleteEmpInfoRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteEmpInfoRequest setParams(java.util.List<HrbrainDeleteEmpInfoRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteEmpInfoRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteEmpInfoRequestParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteEmpInfoRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteEmpInfoRequestParams self = new HrbrainDeleteEmpInfoRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteEmpInfoRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
