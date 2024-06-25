// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetAppsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>success</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public java.util.List<GetAppsResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OK</p>
     */
    @NameInMap("message")
    public String message;

    public static GetAppsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAppsResponseBody self = new GetAppsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAppsResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetAppsResponseBody setData(java.util.List<GetAppsResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetAppsResponseBodyData> getData() {
        return this.data;
    }

    public GetAppsResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetAppsResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>D000183inventory</p>
         */
        @NameInMap("appCode")
        public String appCode;

        /**
         * <strong>example:</strong>
         * <p>Installed</p>
         */
        @NameInMap("appSource")
        public String appSource;

        /**
         * <strong>example:</strong>
         * <p>Enable</p>
         */
        @NameInMap("appState")
        public String appState;

        /**
         * <strong>example:</strong>
         * <p>人事管理</p>
         */
        @NameInMap("displayName")
        public String displayName;

        /**
         * <strong>example:</strong>
         * <p>dev001</p>
         */
        @NameInMap("solution")
        public String solution;

        public static GetAppsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetAppsResponseBodyData self = new GetAppsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetAppsResponseBodyData setAppCode(String appCode) {
            this.appCode = appCode;
            return this;
        }
        public String getAppCode() {
            return this.appCode;
        }

        public GetAppsResponseBodyData setAppSource(String appSource) {
            this.appSource = appSource;
            return this;
        }
        public String getAppSource() {
            return this.appSource;
        }

        public GetAppsResponseBodyData setAppState(String appState) {
            this.appState = appState;
            return this;
        }
        public String getAppState() {
            return this.appState;
        }

        public GetAppsResponseBodyData setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetAppsResponseBodyData setSolution(String solution) {
            this.solution = solution;
            return this;
        }
        public String getSolution() {
            return this.solution;
        }

    }

}
