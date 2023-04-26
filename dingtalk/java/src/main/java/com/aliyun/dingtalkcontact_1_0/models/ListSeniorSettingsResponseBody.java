// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListSeniorSettingsResponseBody extends TeaModel {
    @NameInMap("protectScenes")
    public java.util.List<String> protectScenes;

    @NameInMap("seniorStaffId")
    public String seniorStaffId;

    @NameInMap("seniorWhiteList")
    public java.util.List<ListSeniorSettingsResponseBodySeniorWhiteList> seniorWhiteList;

    public static ListSeniorSettingsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSeniorSettingsResponseBody self = new ListSeniorSettingsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSeniorSettingsResponseBody setProtectScenes(java.util.List<String> protectScenes) {
        this.protectScenes = protectScenes;
        return this;
    }
    public java.util.List<String> getProtectScenes() {
        return this.protectScenes;
    }

    public ListSeniorSettingsResponseBody setSeniorStaffId(String seniorStaffId) {
        this.seniorStaffId = seniorStaffId;
        return this;
    }
    public String getSeniorStaffId() {
        return this.seniorStaffId;
    }

    public ListSeniorSettingsResponseBody setSeniorWhiteList(java.util.List<ListSeniorSettingsResponseBodySeniorWhiteList> seniorWhiteList) {
        this.seniorWhiteList = seniorWhiteList;
        return this;
    }
    public java.util.List<ListSeniorSettingsResponseBodySeniorWhiteList> getSeniorWhiteList() {
        return this.seniorWhiteList;
    }

    public static class ListSeniorSettingsResponseBodySeniorWhiteList extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("type")
        public Integer type;

        public static ListSeniorSettingsResponseBodySeniorWhiteList build(java.util.Map<String, ?> map) throws Exception {
            ListSeniorSettingsResponseBodySeniorWhiteList self = new ListSeniorSettingsResponseBodySeniorWhiteList();
            return TeaModel.build(map, self);
        }

        public ListSeniorSettingsResponseBodySeniorWhiteList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListSeniorSettingsResponseBodySeniorWhiteList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListSeniorSettingsResponseBodySeniorWhiteList setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
