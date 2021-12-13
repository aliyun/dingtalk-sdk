// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetAppsResponseBody extends TeaModel {
    // 状态码
    @NameInMap("code")
    public String code;

    // 提示信息
    @NameInMap("message")
    public String message;

    // 返回结果
    @NameInMap("data")
    public java.util.List<GetAppsResponseBodyData> data;

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

    public GetAppsResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public GetAppsResponseBody setData(java.util.List<GetAppsResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetAppsResponseBodyData> getData() {
        return this.data;
    }

    public static class GetAppsResponseBodyData extends TeaModel {
        // 应用编码
        @NameInMap("appCode")
        public String appCode;

        // 应用显示名称
        @NameInMap("displayName")
        public String displayName;

        // 应用的来源类型。Custom=自开发的、Installed=安装的
        @NameInMap("appSource")
        public String appSource;

        // 应用状态。Enable=启用、Forbidden=禁用、Warring=预警
        @NameInMap("appState")
        public String appState;

        // 应用所属的解决方案名称
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

        public GetAppsResponseBodyData setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
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

        public GetAppsResponseBodyData setSolution(String solution) {
            this.solution = solution;
            return this;
        }
        public String getSolution() {
            return this.solution;
        }

    }

}
