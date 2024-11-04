// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteLabelIndustryRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteLabelIndustryRequestParams> params;

    public static HrbrainDeleteLabelIndustryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteLabelIndustryRequest self = new HrbrainDeleteLabelIndustryRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteLabelIndustryRequest setParams(java.util.List<HrbrainDeleteLabelIndustryRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteLabelIndustryRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteLabelIndustryRequestParams extends TeaModel {
        @NameInMap("label")
        public java.util.Map<String, ?> label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteLabelIndustryRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteLabelIndustryRequestParams self = new HrbrainDeleteLabelIndustryRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteLabelIndustryRequestParams setLabel(java.util.Map<String, ?> label) {
            this.label = label;
            return this;
        }
        public java.util.Map<String, ?> getLabel() {
            return this.label;
        }

        public HrbrainDeleteLabelIndustryRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
