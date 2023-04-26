// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class PageInnerAppHistoryVersionResponseBody extends TeaModel {
    @NameInMap("miniAppVersionList")
    public java.util.List<PageInnerAppHistoryVersionResponseBodyMiniAppVersionList> miniAppVersionList;

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
        @NameInMap("appVersion")
        public String appVersion;

        @NameInMap("appVersionId")
        public Long appVersionId;

        @NameInMap("appVersionType")
        public Integer appVersionType;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("miniAppId")
        public String miniAppId;

        @NameInMap("miniAppOnPc")
        public Boolean miniAppOnPc;

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
