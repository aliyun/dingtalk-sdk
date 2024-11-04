// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteWorkExpRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteWorkExpRequestParams> params;

    public static HrbrainDeleteWorkExpRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteWorkExpRequest self = new HrbrainDeleteWorkExpRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteWorkExpRequest setParams(java.util.List<HrbrainDeleteWorkExpRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteWorkExpRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteWorkExpRequestParams extends TeaModel {
        @NameInMap("companyName")
        public String companyName;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("startDate")
        public String startDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteWorkExpRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteWorkExpRequestParams self = new HrbrainDeleteWorkExpRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteWorkExpRequestParams setCompanyName(String companyName) {
            this.companyName = companyName;
            return this;
        }
        public String getCompanyName() {
            return this.companyName;
        }

        public HrbrainDeleteWorkExpRequestParams setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public HrbrainDeleteWorkExpRequestParams setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public HrbrainDeleteWorkExpRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
