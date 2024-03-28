// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelInventoryRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<HrbrainImportLabelInventoryRequestBody> body;

    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportLabelInventoryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportLabelInventoryRequest self = new HrbrainImportLabelInventoryRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportLabelInventoryRequest setBody(java.util.List<HrbrainImportLabelInventoryRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportLabelInventoryRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportLabelInventoryRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportLabelInventoryRequestBody extends TeaModel {
        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("name")
        public String name;

        @NameInMap("period")
        public String period;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportLabelInventoryRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportLabelInventoryRequestBody self = new HrbrainImportLabelInventoryRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportLabelInventoryRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportLabelInventoryRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportLabelInventoryRequestBody setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public HrbrainImportLabelInventoryRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
