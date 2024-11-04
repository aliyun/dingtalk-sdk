// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteLabelInventoryRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteLabelInventoryRequestParams> params;

    public static HrbrainDeleteLabelInventoryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteLabelInventoryRequest self = new HrbrainDeleteLabelInventoryRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteLabelInventoryRequest setParams(java.util.List<HrbrainDeleteLabelInventoryRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteLabelInventoryRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteLabelInventoryRequestParams extends TeaModel {
        @NameInMap("label")
        public java.util.Map<String, ?> label;

        @NameInMap("period")
        public String period;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteLabelInventoryRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteLabelInventoryRequestParams self = new HrbrainDeleteLabelInventoryRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteLabelInventoryRequestParams setLabel(java.util.Map<String, ?> label) {
            this.label = label;
            return this;
        }
        public java.util.Map<String, ?> getLabel() {
            return this.label;
        }

        public HrbrainDeleteLabelInventoryRequestParams setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public HrbrainDeleteLabelInventoryRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
