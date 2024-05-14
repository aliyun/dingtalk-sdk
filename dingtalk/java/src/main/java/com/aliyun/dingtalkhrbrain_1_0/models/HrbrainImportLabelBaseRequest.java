// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelBaseRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<HrbrainImportLabelBaseRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportLabelBaseRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportLabelBaseRequest self = new HrbrainImportLabelBaseRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportLabelBaseRequest setBody(java.util.List<HrbrainImportLabelBaseRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportLabelBaseRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportLabelBaseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportLabelBaseRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportLabelBaseRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportLabelBaseRequestBody self = new HrbrainImportLabelBaseRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportLabelBaseRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportLabelBaseRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportLabelBaseRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
