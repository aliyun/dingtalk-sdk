// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddHrmPreentryRequest extends TeaModel {
    @NameInMap("preEntryTime")
    public Long preEntryTime;

    @NameInMap("name")
    public String name;

    @NameInMap("mobile")
    public String mobile;

    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("groups")
    public java.util.List<AddHrmPreentryRequestGroups> groups;

    public static AddHrmPreentryRequest build(java.util.Map<String, ?> map) throws Exception {
        AddHrmPreentryRequest self = new AddHrmPreentryRequest();
        return TeaModel.build(map, self);
    }

    public AddHrmPreentryRequest setPreEntryTime(Long preEntryTime) {
        this.preEntryTime = preEntryTime;
        return this;
    }
    public Long getPreEntryTime() {
        return this.preEntryTime;
    }

    public AddHrmPreentryRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddHrmPreentryRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public AddHrmPreentryRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public AddHrmPreentryRequest setGroups(java.util.List<AddHrmPreentryRequestGroups> groups) {
        this.groups = groups;
        return this;
    }
    public java.util.List<AddHrmPreentryRequestGroups> getGroups() {
        return this.groups;
    }

    public static class AddHrmPreentryRequestGroupsSectionsEmpFieldVOList extends TeaModel {
        @NameInMap("value")
        public String value;

        @NameInMap("fieldCode")
        public String fieldCode;

        public static AddHrmPreentryRequestGroupsSectionsEmpFieldVOList build(java.util.Map<String, ?> map) throws Exception {
            AddHrmPreentryRequestGroupsSectionsEmpFieldVOList self = new AddHrmPreentryRequestGroupsSectionsEmpFieldVOList();
            return TeaModel.build(map, self);
        }

        public AddHrmPreentryRequestGroupsSectionsEmpFieldVOList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public AddHrmPreentryRequestGroupsSectionsEmpFieldVOList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

    }

    public static class AddHrmPreentryRequestGroupsSections extends TeaModel {
        @NameInMap("oldIndex")
        public Integer oldIndex;

        @NameInMap("empFieldVOList")
        public java.util.List<AddHrmPreentryRequestGroupsSectionsEmpFieldVOList> empFieldVOList;

        public static AddHrmPreentryRequestGroupsSections build(java.util.Map<String, ?> map) throws Exception {
            AddHrmPreentryRequestGroupsSections self = new AddHrmPreentryRequestGroupsSections();
            return TeaModel.build(map, self);
        }

        public AddHrmPreentryRequestGroupsSections setOldIndex(Integer oldIndex) {
            this.oldIndex = oldIndex;
            return this;
        }
        public Integer getOldIndex() {
            return this.oldIndex;
        }

        public AddHrmPreentryRequestGroupsSections setEmpFieldVOList(java.util.List<AddHrmPreentryRequestGroupsSectionsEmpFieldVOList> empFieldVOList) {
            this.empFieldVOList = empFieldVOList;
            return this;
        }
        public java.util.List<AddHrmPreentryRequestGroupsSectionsEmpFieldVOList> getEmpFieldVOList() {
            return this.empFieldVOList;
        }

    }

    public static class AddHrmPreentryRequestGroups extends TeaModel {
        @NameInMap("groupId")
        public String groupId;

        @NameInMap("sections")
        public java.util.List<AddHrmPreentryRequestGroupsSections> sections;

        public static AddHrmPreentryRequestGroups build(java.util.Map<String, ?> map) throws Exception {
            AddHrmPreentryRequestGroups self = new AddHrmPreentryRequestGroups();
            return TeaModel.build(map, self);
        }

        public AddHrmPreentryRequestGroups setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public AddHrmPreentryRequestGroups setSections(java.util.List<AddHrmPreentryRequestGroupsSections> sections) {
            this.sections = sections;
            return this;
        }
        public java.util.List<AddHrmPreentryRequestGroupsSections> getSections() {
            return this.sections;
        }

    }

}
