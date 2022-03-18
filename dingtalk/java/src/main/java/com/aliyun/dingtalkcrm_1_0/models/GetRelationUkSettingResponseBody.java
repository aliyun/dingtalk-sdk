// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelationUkSettingResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetRelationUkSettingResponseBodyResult> result;

    public static GetRelationUkSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRelationUkSettingResponseBody self = new GetRelationUkSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRelationUkSettingResponseBody setResult(java.util.List<GetRelationUkSettingResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetRelationUkSettingResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetRelationUkSettingResponseBodyResult extends TeaModel {
        // 查重字段的bizAlias
        @NameInMap("bizAlias")
        public String bizAlias;

        // 查重字段的字段id
        @NameInMap("fieldId")
        public String fieldId;

        public static GetRelationUkSettingResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRelationUkSettingResponseBodyResult self = new GetRelationUkSettingResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRelationUkSettingResponseBodyResult setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public GetRelationUkSettingResponseBodyResult setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

}
