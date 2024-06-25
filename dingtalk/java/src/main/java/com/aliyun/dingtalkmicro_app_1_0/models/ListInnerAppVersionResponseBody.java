// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListInnerAppVersionResponseBody extends TeaModel {
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0.0.1</p>
         */
        @NameInMap("appVersion")
        public String appVersion;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("appVersionId")
        public Long appVersionId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("appVersionType")
        public Integer appVersionType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2023-01-01 00:00:00</p>
         */
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("entranceLink")
        public String entranceLink;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("miniAppId")
        public String miniAppId;

        @NameInMap("miniAppOnPc")
        public Boolean miniAppOnPc;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2023-01-01 00:00:00</p>
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

        public ListInnerAppVersionResponseBodyAppVersionList setEntranceLink(String entranceLink) {
            this.entranceLink = entranceLink;
            return this;
        }
        public String getEntranceLink() {
            return this.entranceLink;
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
