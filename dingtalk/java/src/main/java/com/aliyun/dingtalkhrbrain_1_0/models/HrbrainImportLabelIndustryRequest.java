// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelIndustryRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<HrbrainImportLabelIndustryRequestBody> body;

    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportLabelIndustryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportLabelIndustryRequest self = new HrbrainImportLabelIndustryRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportLabelIndustryRequest setBody(java.util.List<HrbrainImportLabelIndustryRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportLabelIndustryRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportLabelIndustryRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportLabelIndustryRequestBody extends TeaModel {
        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("level1")
        public String level1;

        @NameInMap("level2")
        public String level2;

        @NameInMap("level3")
        public String level3;

        @NameInMap("name")
        public String name;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportLabelIndustryRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportLabelIndustryRequestBody self = new HrbrainImportLabelIndustryRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportLabelIndustryRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportLabelIndustryRequestBody setLevel1(String level1) {
            this.level1 = level1;
            return this;
        }
        public String getLevel1() {
            return this.level1;
        }

        public HrbrainImportLabelIndustryRequestBody setLevel2(String level2) {
            this.level2 = level2;
            return this;
        }
        public String getLevel2() {
            return this.level2;
        }

        public HrbrainImportLabelIndustryRequestBody setLevel3(String level3) {
            this.level3 = level3;
            return this;
        }
        public String getLevel3() {
            return this.level3;
        }

        public HrbrainImportLabelIndustryRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportLabelIndustryRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
