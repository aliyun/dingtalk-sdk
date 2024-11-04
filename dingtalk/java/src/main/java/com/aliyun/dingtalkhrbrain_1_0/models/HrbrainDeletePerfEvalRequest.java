// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeletePerfEvalRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeletePerfEvalRequestParams> params;

    public static HrbrainDeletePerfEvalRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeletePerfEvalRequest self = new HrbrainDeletePerfEvalRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeletePerfEvalRequest setParams(java.util.List<HrbrainDeletePerfEvalRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeletePerfEvalRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeletePerfEvalRequestParams extends TeaModel {
        @NameInMap("perfPlanName")
        public String perfPlanName;

        @NameInMap("period")
        public String period;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeletePerfEvalRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeletePerfEvalRequestParams self = new HrbrainDeletePerfEvalRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeletePerfEvalRequestParams setPerfPlanName(String perfPlanName) {
            this.perfPlanName = perfPlanName;
            return this;
        }
        public String getPerfPlanName() {
            return this.perfPlanName;
        }

        public HrbrainDeletePerfEvalRequestParams setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public HrbrainDeletePerfEvalRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
