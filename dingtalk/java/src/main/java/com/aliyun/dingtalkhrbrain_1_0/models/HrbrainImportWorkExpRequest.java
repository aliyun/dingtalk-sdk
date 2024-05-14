// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportWorkExpRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<HrbrainImportWorkExpRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportWorkExpRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportWorkExpRequest self = new HrbrainImportWorkExpRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportWorkExpRequest setBody(java.util.List<HrbrainImportWorkExpRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportWorkExpRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportWorkExpRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportWorkExpRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("companyName")
        public String companyName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("jobDesc")
        public String jobDesc;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("postName")
        public String postName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportWorkExpRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportWorkExpRequestBody self = new HrbrainImportWorkExpRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportWorkExpRequestBody setCompanyName(String companyName) {
            this.companyName = companyName;
            return this;
        }
        public String getCompanyName() {
            return this.companyName;
        }

        public HrbrainImportWorkExpRequestBody setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public HrbrainImportWorkExpRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportWorkExpRequestBody setJobDesc(String jobDesc) {
            this.jobDesc = jobDesc;
            return this;
        }
        public String getJobDesc() {
            return this.jobDesc;
        }

        public HrbrainImportWorkExpRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportWorkExpRequestBody setPostName(String postName) {
            this.postName = postName;
            return this;
        }
        public String getPostName() {
            return this.postName;
        }

        public HrbrainImportWorkExpRequestBody setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public HrbrainImportWorkExpRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
