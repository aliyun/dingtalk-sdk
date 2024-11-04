// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteAwardRecordsRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteAwardRecordsRequestParams> params;

    public static HrbrainDeleteAwardRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteAwardRecordsRequest self = new HrbrainDeleteAwardRecordsRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteAwardRecordsRequest setParams(java.util.List<HrbrainDeleteAwardRecordsRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteAwardRecordsRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteAwardRecordsRequestParams extends TeaModel {
        @NameInMap("awardDate")
        public String awardDate;

        @NameInMap("awardName")
        public String awardName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteAwardRecordsRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteAwardRecordsRequestParams self = new HrbrainDeleteAwardRecordsRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteAwardRecordsRequestParams setAwardDate(String awardDate) {
            this.awardDate = awardDate;
            return this;
        }
        public String getAwardDate() {
            return this.awardDate;
        }

        public HrbrainDeleteAwardRecordsRequestParams setAwardName(String awardName) {
            this.awardName = awardName;
            return this;
        }
        public String getAwardName() {
            return this.awardName;
        }

        public HrbrainDeleteAwardRecordsRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
