// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelDataDeleteRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainLabelDataDeleteRequestParams> params;

    public static HrbrainLabelDataDeleteRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelDataDeleteRequest self = new HrbrainLabelDataDeleteRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelDataDeleteRequest setParams(java.util.List<HrbrainLabelDataDeleteRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainLabelDataDeleteRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainLabelDataDeleteRequestParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("labelCodes")
        public java.util.List<String> labelCodes;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainLabelDataDeleteRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelDataDeleteRequestParams self = new HrbrainLabelDataDeleteRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelDataDeleteRequestParams setLabelCodes(java.util.List<String> labelCodes) {
            this.labelCodes = labelCodes;
            return this;
        }
        public java.util.List<String> getLabelCodes() {
            return this.labelCodes;
        }

        public HrbrainLabelDataDeleteRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
