// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteLabelProfSkillRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteLabelProfSkillRequestParams> params;

    public static HrbrainDeleteLabelProfSkillRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteLabelProfSkillRequest self = new HrbrainDeleteLabelProfSkillRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteLabelProfSkillRequest setParams(java.util.List<HrbrainDeleteLabelProfSkillRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteLabelProfSkillRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteLabelProfSkillRequestParams extends TeaModel {
        @NameInMap("label")
        public java.util.Map<String, ?> label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteLabelProfSkillRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteLabelProfSkillRequestParams self = new HrbrainDeleteLabelProfSkillRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteLabelProfSkillRequestParams setLabel(java.util.Map<String, ?> label) {
            this.label = label;
            return this;
        }
        public java.util.Map<String, ?> getLabel() {
            return this.label;
        }

        public HrbrainDeleteLabelProfSkillRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
