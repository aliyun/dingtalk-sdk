// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeletetLabelBaseRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeletetLabelBaseRequestParams> params;

    public static HrbrainDeletetLabelBaseRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeletetLabelBaseRequest self = new HrbrainDeletetLabelBaseRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeletetLabelBaseRequest setParams(java.util.List<HrbrainDeletetLabelBaseRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeletetLabelBaseRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeletetLabelBaseRequestParams extends TeaModel {
        @NameInMap("label")
        public java.util.Map<String, ?> label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeletetLabelBaseRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeletetLabelBaseRequestParams self = new HrbrainDeletetLabelBaseRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeletetLabelBaseRequestParams setLabel(java.util.Map<String, ?> label) {
            this.label = label;
            return this;
        }
        public java.util.Map<String, ?> getLabel() {
            return this.label;
        }

        public HrbrainDeletetLabelBaseRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
