// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelDataUpsertRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("params")
    public java.util.List<HrbrainLabelDataUpsertRequestParams> params;

    public static HrbrainLabelDataUpsertRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelDataUpsertRequest self = new HrbrainLabelDataUpsertRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelDataUpsertRequest setParams(java.util.List<HrbrainLabelDataUpsertRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainLabelDataUpsertRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainLabelDataUpsertRequestParamsLabelDatas extends TeaModel {
        @NameInMap("labelCode")
        public String labelCode;

        @NameInMap("labelValue")
        public java.util.List<String> labelValue;

        public static HrbrainLabelDataUpsertRequestParamsLabelDatas build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelDataUpsertRequestParamsLabelDatas self = new HrbrainLabelDataUpsertRequestParamsLabelDatas();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelDataUpsertRequestParamsLabelDatas setLabelCode(String labelCode) {
            this.labelCode = labelCode;
            return this;
        }
        public String getLabelCode() {
            return this.labelCode;
        }

        public HrbrainLabelDataUpsertRequestParamsLabelDatas setLabelValue(java.util.List<String> labelValue) {
            this.labelValue = labelValue;
            return this;
        }
        public java.util.List<String> getLabelValue() {
            return this.labelValue;
        }

    }

    public static class HrbrainLabelDataUpsertRequestParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("labelDatas")
        public java.util.List<HrbrainLabelDataUpsertRequestParamsLabelDatas> labelDatas;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainLabelDataUpsertRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelDataUpsertRequestParams self = new HrbrainLabelDataUpsertRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelDataUpsertRequestParams setLabelDatas(java.util.List<HrbrainLabelDataUpsertRequestParamsLabelDatas> labelDatas) {
            this.labelDatas = labelDatas;
            return this;
        }
        public java.util.List<HrbrainLabelDataUpsertRequestParamsLabelDatas> getLabelDatas() {
            return this.labelDatas;
        }

        public HrbrainLabelDataUpsertRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
