// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportAwardDetailRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<HrbrainImportAwardDetailRequestBody> body;

    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportAwardDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportAwardDetailRequest self = new HrbrainImportAwardDetailRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportAwardDetailRequest setBody(java.util.List<HrbrainImportAwardDetailRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportAwardDetailRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportAwardDetailRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportAwardDetailRequestBody extends TeaModel {
        @NameInMap("awardDate")
        public String awardDate;

        @NameInMap("awardName")
        public String awardName;

        @NameInMap("awardOrg")
        public String awardOrg;

        @NameInMap("awardType")
        public String awardType;

        @NameInMap("comment")
        public String comment;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("name")
        public String name;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportAwardDetailRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportAwardDetailRequestBody self = new HrbrainImportAwardDetailRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportAwardDetailRequestBody setAwardDate(String awardDate) {
            this.awardDate = awardDate;
            return this;
        }
        public String getAwardDate() {
            return this.awardDate;
        }

        public HrbrainImportAwardDetailRequestBody setAwardName(String awardName) {
            this.awardName = awardName;
            return this;
        }
        public String getAwardName() {
            return this.awardName;
        }

        public HrbrainImportAwardDetailRequestBody setAwardOrg(String awardOrg) {
            this.awardOrg = awardOrg;
            return this;
        }
        public String getAwardOrg() {
            return this.awardOrg;
        }

        public HrbrainImportAwardDetailRequestBody setAwardType(String awardType) {
            this.awardType = awardType;
            return this;
        }
        public String getAwardType() {
            return this.awardType;
        }

        public HrbrainImportAwardDetailRequestBody setComment(String comment) {
            this.comment = comment;
            return this;
        }
        public String getComment() {
            return this.comment;
        }

        public HrbrainImportAwardDetailRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportAwardDetailRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportAwardDetailRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
