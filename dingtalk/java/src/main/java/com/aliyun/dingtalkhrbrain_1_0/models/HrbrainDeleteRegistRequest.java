// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteRegistRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteRegistRequestParams> params;

    public static HrbrainDeleteRegistRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteRegistRequest self = new HrbrainDeleteRegistRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteRegistRequest setParams(java.util.List<HrbrainDeleteRegistRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteRegistRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteRegistRequestParams extends TeaModel {
        @NameInMap("registDate")
        public String registDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteRegistRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteRegistRequestParams self = new HrbrainDeleteRegistRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteRegistRequestParams setRegistDate(String registDate) {
            this.registDate = registDate;
            return this;
        }
        public String getRegistDate() {
            return this.registDate;
        }

        public HrbrainDeleteRegistRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
