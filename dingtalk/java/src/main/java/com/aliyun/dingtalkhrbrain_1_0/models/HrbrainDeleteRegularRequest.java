// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteRegularRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteRegularRequestParams> params;

    public static HrbrainDeleteRegularRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteRegularRequest self = new HrbrainDeleteRegularRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteRegularRequest setParams(java.util.List<HrbrainDeleteRegularRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteRegularRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteRegularRequestParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("regularDate")
        public String regularDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteRegularRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteRegularRequestParams self = new HrbrainDeleteRegularRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteRegularRequestParams setRegularDate(String regularDate) {
            this.regularDate = regularDate;
            return this;
        }
        public String getRegularDate() {
            return this.regularDate;
        }

        public HrbrainDeleteRegularRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
