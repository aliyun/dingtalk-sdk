// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListInnerAppVersionResponseBody extends TeaModel {
    /**
     * <p>企业内部小程序版本号列表</p>
     */
    @NameInMap("appVersionList")
    public java.util.List<ListInnerAppVersionResponseBodyAppVersionList> appVersionList;

    public static ListInnerAppVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListInnerAppVersionResponseBody self = new ListInnerAppVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public ListInnerAppVersionResponseBody setAppVersionList(java.util.List<ListInnerAppVersionResponseBodyAppVersionList> appVersionList) {
        this.appVersionList = appVersionList;
        return this;
    }
    public java.util.List<ListInnerAppVersionResponseBodyAppVersionList> getAppVersionList() {
        return this.appVersionList;
    }

    public static class ListInnerAppVersionResponseBodyAppVersionList extends TeaModel {
        /**
         * <p>小程序版本号</p>
         */
        @NameInMap("appVersion")
        public String appVersion;

        /**
         * <p>小程序版本id，用于发布和回滚的版本唯一标识。</p>
         */
        @NameInMap("appVersionId")
        public Long appVersionId;

        /**
         * <p>小程序版本类型，0表示开发版本，2表示正式版本，3表示体验版本</p>
         */
        @NameInMap("appVersionType")
        public Integer appVersionType;

        /**
         * <p>小程序版本创建事件，格式:yyyy-MM-dd HH:mm:ss</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>小程序id</p>
         */
        @NameInMap("miniAppId")
        public String miniAppId;

        /**
         * <p>是否支持PC端打开小程序，false表示只支持移动端，true表示既支持移动端又支持PC端  </p>
         */
        @NameInMap("miniAppOnPc")
        public Boolean miniAppOnPc;

        /**
         * <p>小程序版本号更新时间，格式:yyyy-MM-dd HH:mm:ss</p>
         */
        @NameInMap("modifyTime")
        public String modifyTime;

        public static ListInnerAppVersionResponseBodyAppVersionList build(java.util.Map<String, ?> map) throws Exception {
            ListInnerAppVersionResponseBodyAppVersionList self = new ListInnerAppVersionResponseBodyAppVersionList();
            return TeaModel.build(map, self);
        }

        public ListInnerAppVersionResponseBodyAppVersionList setAppVersion(String appVersion) {
            this.appVersion = appVersion;
            return this;
        }
        public String getAppVersion() {
            return this.appVersion;
        }

        public ListInnerAppVersionResponseBodyAppVersionList setAppVersionId(Long appVersionId) {
            this.appVersionId = appVersionId;
            return this;
        }
        public Long getAppVersionId() {
            return this.appVersionId;
        }

        public ListInnerAppVersionResponseBodyAppVersionList setAppVersionType(Integer appVersionType) {
            this.appVersionType = appVersionType;
            return this;
        }
        public Integer getAppVersionType() {
            return this.appVersionType;
        }

        public ListInnerAppVersionResponseBodyAppVersionList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListInnerAppVersionResponseBodyAppVersionList setMiniAppId(String miniAppId) {
            this.miniAppId = miniAppId;
            return this;
        }
        public String getMiniAppId() {
            return this.miniAppId;
        }

        public ListInnerAppVersionResponseBodyAppVersionList setMiniAppOnPc(Boolean miniAppOnPc) {
            this.miniAppOnPc = miniAppOnPc;
            return this;
        }
        public Boolean getMiniAppOnPc() {
            return this.miniAppOnPc;
        }

        public ListInnerAppVersionResponseBodyAppVersionList setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

    }

}
