// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class PageInnerAppHistoryVersionResponseBody extends TeaModel {
    /**
     * <p>企业内部小程序版本号列表</p>
     */
    @NameInMap("miniAppVersionList")
    public java.util.List<PageInnerAppHistoryVersionResponseBodyMiniAppVersionList> miniAppVersionList;

    /**
     * <p>当前小程序历史版本的总数量</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static PageInnerAppHistoryVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageInnerAppHistoryVersionResponseBody self = new PageInnerAppHistoryVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public PageInnerAppHistoryVersionResponseBody setMiniAppVersionList(java.util.List<PageInnerAppHistoryVersionResponseBodyMiniAppVersionList> miniAppVersionList) {
        this.miniAppVersionList = miniAppVersionList;
        return this;
    }
    public java.util.List<PageInnerAppHistoryVersionResponseBodyMiniAppVersionList> getMiniAppVersionList() {
        return this.miniAppVersionList;
    }

    public PageInnerAppHistoryVersionResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class PageInnerAppHistoryVersionResponseBodyMiniAppVersionList extends TeaModel {
        /**
         * <p>小程序版本号</p>
         */
        @NameInMap("appVersion")
        public String appVersion;

        /**
         * <p>小程序版本号id，用于小程序的发布和回滚等操作的唯一标识。</p>
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

        public static PageInnerAppHistoryVersionResponseBodyMiniAppVersionList build(java.util.Map<String, ?> map) throws Exception {
            PageInnerAppHistoryVersionResponseBodyMiniAppVersionList self = new PageInnerAppHistoryVersionResponseBodyMiniAppVersionList();
            return TeaModel.build(map, self);
        }

        public PageInnerAppHistoryVersionResponseBodyMiniAppVersionList setAppVersion(String appVersion) {
            this.appVersion = appVersion;
            return this;
        }
        public String getAppVersion() {
            return this.appVersion;
        }

        public PageInnerAppHistoryVersionResponseBodyMiniAppVersionList setAppVersionId(Long appVersionId) {
            this.appVersionId = appVersionId;
            return this;
        }
        public Long getAppVersionId() {
            return this.appVersionId;
        }

        public PageInnerAppHistoryVersionResponseBodyMiniAppVersionList setAppVersionType(Integer appVersionType) {
            this.appVersionType = appVersionType;
            return this;
        }
        public Integer getAppVersionType() {
            return this.appVersionType;
        }

        public PageInnerAppHistoryVersionResponseBodyMiniAppVersionList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public PageInnerAppHistoryVersionResponseBodyMiniAppVersionList setMiniAppId(String miniAppId) {
            this.miniAppId = miniAppId;
            return this;
        }
        public String getMiniAppId() {
            return this.miniAppId;
        }

        public PageInnerAppHistoryVersionResponseBodyMiniAppVersionList setMiniAppOnPc(Boolean miniAppOnPc) {
            this.miniAppOnPc = miniAppOnPc;
            return this;
        }
        public Boolean getMiniAppOnPc() {
            return this.miniAppOnPc;
        }

        public PageInnerAppHistoryVersionResponseBodyMiniAppVersionList setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

    }

}
