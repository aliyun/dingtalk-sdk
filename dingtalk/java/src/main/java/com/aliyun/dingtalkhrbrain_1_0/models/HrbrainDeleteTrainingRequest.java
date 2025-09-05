// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteTrainingRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteTrainingRequestParams> params;

    public static HrbrainDeleteTrainingRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteTrainingRequest self = new HrbrainDeleteTrainingRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteTrainingRequest setParams(java.util.List<HrbrainDeleteTrainingRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteTrainingRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteTrainingRequestParams extends TeaModel {
        @NameInMap("trainEndDate")
        public String trainEndDate;

        @NameInMap("trainName")
        public String trainName;

        @NameInMap("trainStartDate")
        public String trainStartDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteTrainingRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteTrainingRequestParams self = new HrbrainDeleteTrainingRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteTrainingRequestParams setTrainEndDate(String trainEndDate) {
            this.trainEndDate = trainEndDate;
            return this;
        }
        public String getTrainEndDate() {
            return this.trainEndDate;
        }

        public HrbrainDeleteTrainingRequestParams setTrainName(String trainName) {
            this.trainName = trainName;
            return this;
        }
        public String getTrainName() {
            return this.trainName;
        }

        public HrbrainDeleteTrainingRequestParams setTrainStartDate(String trainStartDate) {
            this.trainStartDate = trainStartDate;
            return this;
        }
        public String getTrainStartDate() {
            return this.trainStartDate;
        }

        public HrbrainDeleteTrainingRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
