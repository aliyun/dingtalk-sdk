// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_2_0.models;

import com.aliyun.tea.*;

public class GetRelationUkSettingResponseBody extends TeaModel {
    @NameInMap("result")
    public GetRelationUkSettingResponseBodyResult result;

    public static GetRelationUkSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRelationUkSettingResponseBody self = new GetRelationUkSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRelationUkSettingResponseBody setResult(GetRelationUkSettingResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetRelationUkSettingResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList extends TeaModel {
        /**
         * <p>查重字段的bizAlias。</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>查重字段的字段id。</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        public static GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList build(java.util.Map<String, ?> map) throws Exception {
            GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList self = new GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList();
            return TeaModel.build(map, self);
        }

        public GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

    public static class GetRelationUkSettingResponseBodyResultFormUkSettings extends TeaModel {
        @NameInMap("fieldList")
        public java.util.List<GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList> fieldList;

        public static GetRelationUkSettingResponseBodyResultFormUkSettings build(java.util.Map<String, ?> map) throws Exception {
            GetRelationUkSettingResponseBodyResultFormUkSettings self = new GetRelationUkSettingResponseBodyResultFormUkSettings();
            return TeaModel.build(map, self);
        }

        public GetRelationUkSettingResponseBodyResultFormUkSettings setFieldList(java.util.List<GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList> fieldList) {
            this.fieldList = fieldList;
            return this;
        }
        public java.util.List<GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList> getFieldList() {
            return this.fieldList;
        }

    }

    public static class GetRelationUkSettingResponseBodyResult extends TeaModel {
        @NameInMap("formUkSettings")
        public java.util.List<GetRelationUkSettingResponseBodyResultFormUkSettings> formUkSettings;

        /**
         * <p>查重列表表头字段id列表。</p>
         */
        @NameInMap("headerFieldIds")
        public java.util.List<String> headerFieldIds;

        public static GetRelationUkSettingResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRelationUkSettingResponseBodyResult self = new GetRelationUkSettingResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRelationUkSettingResponseBodyResult setFormUkSettings(java.util.List<GetRelationUkSettingResponseBodyResultFormUkSettings> formUkSettings) {
            this.formUkSettings = formUkSettings;
            return this;
        }
        public java.util.List<GetRelationUkSettingResponseBodyResultFormUkSettings> getFormUkSettings() {
            return this.formUkSettings;
        }

        public GetRelationUkSettingResponseBodyResult setHeaderFieldIds(java.util.List<String> headerFieldIds) {
            this.headerFieldIds = headerFieldIds;
            return this;
        }
        public java.util.List<String> getHeaderFieldIds() {
            return this.headerFieldIds;
        }

    }

}
