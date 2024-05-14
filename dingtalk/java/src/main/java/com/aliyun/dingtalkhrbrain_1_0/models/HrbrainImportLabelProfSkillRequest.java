// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelProfSkillRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<HrbrainImportLabelProfSkillRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportLabelProfSkillRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportLabelProfSkillRequest self = new HrbrainImportLabelProfSkillRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportLabelProfSkillRequest setBody(java.util.List<HrbrainImportLabelProfSkillRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportLabelProfSkillRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportLabelProfSkillRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportLabelProfSkillRequestBody extends TeaModel {
        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("level1")
        public String level1;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("level2")
        public String level2;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("level3")
        public String level3;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportLabelProfSkillRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportLabelProfSkillRequestBody self = new HrbrainImportLabelProfSkillRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportLabelProfSkillRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportLabelProfSkillRequestBody setLevel1(String level1) {
            this.level1 = level1;
            return this;
        }
        public String getLevel1() {
            return this.level1;
        }

        public HrbrainImportLabelProfSkillRequestBody setLevel2(String level2) {
            this.level2 = level2;
            return this;
        }
        public String getLevel2() {
            return this.level2;
        }

        public HrbrainImportLabelProfSkillRequestBody setLevel3(String level3) {
            this.level3 = level3;
            return this;
        }
        public String getLevel3() {
            return this.level3;
        }

        public HrbrainImportLabelProfSkillRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportLabelProfSkillRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
