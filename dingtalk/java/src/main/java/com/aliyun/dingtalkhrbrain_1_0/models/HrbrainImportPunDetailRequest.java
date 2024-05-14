// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportPunDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<HrbrainImportPunDetailRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportPunDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportPunDetailRequest self = new HrbrainImportPunDetailRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportPunDetailRequest setBody(java.util.List<HrbrainImportPunDetailRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportPunDetailRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportPunDetailRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportPunDetailRequestBody extends TeaModel {
        @NameInMap("comment")
        public String comment;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("effectiveDate")
        public String effectiveDate;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("punName")
        public String punName;

        @NameInMap("punOrg")
        public String punOrg;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportPunDetailRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportPunDetailRequestBody self = new HrbrainImportPunDetailRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportPunDetailRequestBody setComment(String comment) {
            this.comment = comment;
            return this;
        }
        public String getComment() {
            return this.comment;
        }

        public HrbrainImportPunDetailRequestBody setEffectiveDate(String effectiveDate) {
            this.effectiveDate = effectiveDate;
            return this;
        }
        public String getEffectiveDate() {
            return this.effectiveDate;
        }

        public HrbrainImportPunDetailRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportPunDetailRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportPunDetailRequestBody setPunName(String punName) {
            this.punName = punName;
            return this;
        }
        public String getPunName() {
            return this.punName;
        }

        public HrbrainImportPunDetailRequestBody setPunOrg(String punOrg) {
            this.punOrg = punOrg;
            return this;
        }
        public String getPunOrg() {
            return this.punOrg;
        }

        public HrbrainImportPunDetailRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
