// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPrintAppInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetPrintAppInfoResponseBodyResult> result;

    public static GetPrintAppInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPrintAppInfoResponseBody self = new GetPrintAppInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPrintAppInfoResponseBody setResult(java.util.List<GetPrintAppInfoResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetPrintAppInfoResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetPrintAppInfoResponseBodyResultFormInfoList extends TeaModel {
        // formUuid
        @NameInMap("formUuid")
        public String formUuid;

        // formName
        @NameInMap("formName")
        public String formName;

        public static GetPrintAppInfoResponseBodyResultFormInfoList build(java.util.Map<String, ?> map) throws Exception {
            GetPrintAppInfoResponseBodyResultFormInfoList self = new GetPrintAppInfoResponseBodyResultFormInfoList();
            return TeaModel.build(map, self);
        }

        public GetPrintAppInfoResponseBodyResultFormInfoList setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public GetPrintAppInfoResponseBodyResultFormInfoList setFormName(String formName) {
            this.formName = formName;
            return this;
        }
        public String getFormName() {
            return this.formName;
        }

    }

    public static class GetPrintAppInfoResponseBodyResult extends TeaModel {
        // formInfoList
        @NameInMap("formInfoList")
        public java.util.List<GetPrintAppInfoResponseBodyResultFormInfoList> formInfoList;

        // appType
        @NameInMap("appType")
        public String appType;

        // 应用名称
        @NameInMap("appName")
        public String appName;

        // 图标链接
        @NameInMap("iconUrl")
        public String iconUrl;

        public static GetPrintAppInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetPrintAppInfoResponseBodyResult self = new GetPrintAppInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetPrintAppInfoResponseBodyResult setFormInfoList(java.util.List<GetPrintAppInfoResponseBodyResultFormInfoList> formInfoList) {
            this.formInfoList = formInfoList;
            return this;
        }
        public java.util.List<GetPrintAppInfoResponseBodyResultFormInfoList> getFormInfoList() {
            return this.formInfoList;
        }

        public GetPrintAppInfoResponseBodyResult setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public GetPrintAppInfoResponseBodyResult setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public GetPrintAppInfoResponseBodyResult setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

    }

}
