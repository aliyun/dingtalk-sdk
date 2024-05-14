// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelCustomRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<HrbrainImportLabelCustomRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportLabelCustomRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportLabelCustomRequest self = new HrbrainImportLabelCustomRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportLabelCustomRequest setBody(java.util.List<HrbrainImportLabelCustomRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportLabelCustomRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportLabelCustomRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportLabelCustomRequestBody extends TeaModel {
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
        @NameInMap("tag")
        public String tag;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportLabelCustomRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportLabelCustomRequestBody self = new HrbrainImportLabelCustomRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportLabelCustomRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportLabelCustomRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportLabelCustomRequestBody setTag(String tag) {
            this.tag = tag;
            return this;
        }
        public String getTag() {
            return this.tag;
        }

        public HrbrainImportLabelCustomRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
