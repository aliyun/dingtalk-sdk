// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteEduExpRequest extends TeaModel {
    @NameInMap("params")
    public java.util.List<HrbrainDeleteEduExpRequestParams> params;

    public static HrbrainDeleteEduExpRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteEduExpRequest self = new HrbrainDeleteEduExpRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteEduExpRequest setParams(java.util.List<HrbrainDeleteEduExpRequestParams> params) {
        this.params = params;
        return this;
    }
    public java.util.List<HrbrainDeleteEduExpRequestParams> getParams() {
        return this.params;
    }

    public static class HrbrainDeleteEduExpRequestParams extends TeaModel {
        @NameInMap("eduName")
        public String eduName;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("schoolName")
        public String schoolName;

        @NameInMap("startDate")
        public String startDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainDeleteEduExpRequestParams build(java.util.Map<String, ?> map) throws Exception {
            HrbrainDeleteEduExpRequestParams self = new HrbrainDeleteEduExpRequestParams();
            return TeaModel.build(map, self);
        }

        public HrbrainDeleteEduExpRequestParams setEduName(String eduName) {
            this.eduName = eduName;
            return this;
        }
        public String getEduName() {
            return this.eduName;
        }

        public HrbrainDeleteEduExpRequestParams setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public HrbrainDeleteEduExpRequestParams setSchoolName(String schoolName) {
            this.schoolName = schoolName;
            return this;
        }
        public String getSchoolName() {
            return this.schoolName;
        }

        public HrbrainDeleteEduExpRequestParams setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public HrbrainDeleteEduExpRequestParams setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
