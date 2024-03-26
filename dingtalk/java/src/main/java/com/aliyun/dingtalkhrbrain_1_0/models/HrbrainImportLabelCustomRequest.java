// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelCustomRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<HrbrainImportLabelCustomRequestBody> body;

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

        @NameInMap("name")
        public String name;

        @NameInMap("tag")
        public String tag;

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
