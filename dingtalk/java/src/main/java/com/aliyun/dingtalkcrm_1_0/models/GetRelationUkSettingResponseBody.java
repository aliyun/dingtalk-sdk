// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelationUkSettingResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>customer_name</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>TextField_U2K5A122</p>
         */
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
