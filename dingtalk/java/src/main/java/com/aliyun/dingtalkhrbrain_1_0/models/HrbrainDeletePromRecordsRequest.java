// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeletePromRecordsRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeletePromRecordsRequestParams> params;

    public static HrbrainDeletePromRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeletePromRecordsRequest self = new HrbrainDeletePromRecordsRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeletePromRecordsRequest setParams(java.util.List<HrbrainDeletePromRecordsRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeletePromRecordsRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeletePromRecordsRequestParams extends TeaModel {
        @NameInMap("awardDate")
        public String awardDate;

        @NameInMap("awardName")
        public String awardName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeletePromRecordsRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeletePromRecordsRequestParams self = new HrbrainDeletePromRecordsRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeletePromRecordsRequestParams setAwardDate(String awardDate) {
            this.awardDate = awardDate;
            return this;
        }
        public String getAwardDate() {
            return this.awardDate;
        }

        public HrbrainDeletePromRecordsRequestParams setAwardName(String awardName) {
            this.awardName = awardName;
            return this;
        }
        public String getAwardName() {
            return this.awardName;
        }

        public HrbrainDeletePromRecordsRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
