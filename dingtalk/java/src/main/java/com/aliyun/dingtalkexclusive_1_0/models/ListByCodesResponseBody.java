// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListByCodesResponseBody extends TeaModel {
    @NameInMap("robotInfoList")
    public java.util.List<ListByCodesResponseBodyRobotInfoList> robotInfoList;

    public static ListByCodesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListByCodesResponseBody self = new ListByCodesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListByCodesResponseBody setRobotInfoList(java.util.List<ListByCodesResponseBodyRobotInfoList> robotInfoList) {
        this.robotInfoList = robotInfoList;
        return this;
    }
    public java.util.List<ListByCodesResponseBodyRobotInfoList> getRobotInfoList() {
        return this.robotInfoList;
    }

    public static class ListByCodesResponseBodyRobotInfoList extends TeaModel {
        @NameInMap("brief")
        public String brief;

        @NameInMap("code")
        public String code;

        @NameInMap("createAt")
        public Long createAt;

        @NameInMap("description")
        public String description;

        @NameInMap("dev")
        public String dev;

        @NameInMap("icon")
        public String icon;

        @NameInMap("modifiedAt")
        public Long modifiedAt;

        @NameInMap("name")
        public String name;

        @NameInMap("outgoingToken")
        public String outgoingToken;

        @NameInMap("outgoingUrl")
        public String outgoingUrl;

        @NameInMap("previewMediaId")
        public String previewMediaId;

        @NameInMap("sourceUrl")
        public String sourceUrl;

        @NameInMap("status")
        public Integer status;

        public static ListByCodesResponseBodyRobotInfoList build(java.util.Map<String, ?> map) throws Exception {
            ListByCodesResponseBodyRobotInfoList self = new ListByCodesResponseBodyRobotInfoList();
            return TeaModel.build(map, self);
        }

        public ListByCodesResponseBodyRobotInfoList setBrief(String brief) {
            this.brief = brief;
            return this;
        }
        public String getBrief() {
            return this.brief;
        }

        public ListByCodesResponseBodyRobotInfoList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public ListByCodesResponseBodyRobotInfoList setCreateAt(Long createAt) {
            this.createAt = createAt;
            return this;
        }
        public Long getCreateAt() {
            return this.createAt;
        }

        public ListByCodesResponseBodyRobotInfoList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListByCodesResponseBodyRobotInfoList setDev(String dev) {
            this.dev = dev;
            return this;
        }
        public String getDev() {
            return this.dev;
        }

        public ListByCodesResponseBodyRobotInfoList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListByCodesResponseBodyRobotInfoList setModifiedAt(Long modifiedAt) {
            this.modifiedAt = modifiedAt;
            return this;
        }
        public Long getModifiedAt() {
            return this.modifiedAt;
        }

        public ListByCodesResponseBodyRobotInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListByCodesResponseBodyRobotInfoList setOutgoingToken(String outgoingToken) {
            this.outgoingToken = outgoingToken;
            return this;
        }
        public String getOutgoingToken() {
            return this.outgoingToken;
        }

        public ListByCodesResponseBodyRobotInfoList setOutgoingUrl(String outgoingUrl) {
            this.outgoingUrl = outgoingUrl;
            return this;
        }
        public String getOutgoingUrl() {
            return this.outgoingUrl;
        }

        public ListByCodesResponseBodyRobotInfoList setPreviewMediaId(String previewMediaId) {
            this.previewMediaId = previewMediaId;
            return this;
        }
        public String getPreviewMediaId() {
            return this.previewMediaId;
        }

        public ListByCodesResponseBodyRobotInfoList setSourceUrl(String sourceUrl) {
            this.sourceUrl = sourceUrl;
            return this;
        }
        public String getSourceUrl() {
            return this.sourceUrl;
        }

        public ListByCodesResponseBodyRobotInfoList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

}
