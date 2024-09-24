// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GroupQueryByOpenIdResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public GroupQueryByOpenIdResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static GroupQueryByOpenIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupQueryByOpenIdResponseBody self = new GroupQueryByOpenIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupQueryByOpenIdResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GroupQueryByOpenIdResponseBody setData(GroupQueryByOpenIdResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GroupQueryByOpenIdResponseBodyData getData() {
        return this.data;
    }

    public GroupQueryByOpenIdResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr extends TeaModel {
        @NameInMap("attrCode")
        public String attrCode;

        @NameInMap("listAttrOptionsCode")
        public java.util.List<String> listAttrOptionsCode;

        public static GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr build(java.util.Map<String, ?> map) throws Exception {
            GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr self = new GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr();
            return TeaModel.build(map, self);
        }

        public GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr setAttrCode(String attrCode) {
            this.attrCode = attrCode;
            return this;
        }
        public String getAttrCode() {
            return this.attrCode;
        }

        public GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr setListAttrOptionsCode(java.util.List<String> listAttrOptionsCode) {
            this.listAttrOptionsCode = listAttrOptionsCode;
            return this;
        }
        public java.util.List<String> getListAttrOptionsCode() {
            return this.listAttrOptionsCode;
        }

    }

    public static class GroupQueryByOpenIdResponseBodyData extends TeaModel {
        @NameInMap("groupName")
        public String groupName;

        @NameInMap("groupTemplateId")
        public String groupTemplateId;

        @NameInMap("groupTemplateName")
        public String groupTemplateName;

        @NameInMap("groupTopic")
        public String groupTopic;

        @NameInMap("groupType")
        public String groupType;

        @NameInMap("id")
        public Long id;

        @NameInMap("listGroupDynamicAttr")
        public java.util.List<GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr> listGroupDynamicAttr;

        @NameInMap("openConversationId")
        public String openConversationId;

        public static GroupQueryByOpenIdResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GroupQueryByOpenIdResponseBodyData self = new GroupQueryByOpenIdResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GroupQueryByOpenIdResponseBodyData setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public GroupQueryByOpenIdResponseBodyData setGroupTemplateId(String groupTemplateId) {
            this.groupTemplateId = groupTemplateId;
            return this;
        }
        public String getGroupTemplateId() {
            return this.groupTemplateId;
        }

        public GroupQueryByOpenIdResponseBodyData setGroupTemplateName(String groupTemplateName) {
            this.groupTemplateName = groupTemplateName;
            return this;
        }
        public String getGroupTemplateName() {
            return this.groupTemplateName;
        }

        public GroupQueryByOpenIdResponseBodyData setGroupTopic(String groupTopic) {
            this.groupTopic = groupTopic;
            return this;
        }
        public String getGroupTopic() {
            return this.groupTopic;
        }

        public GroupQueryByOpenIdResponseBodyData setGroupType(String groupType) {
            this.groupType = groupType;
            return this;
        }
        public String getGroupType() {
            return this.groupType;
        }

        public GroupQueryByOpenIdResponseBodyData setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GroupQueryByOpenIdResponseBodyData setListGroupDynamicAttr(java.util.List<GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr> listGroupDynamicAttr) {
            this.listGroupDynamicAttr = listGroupDynamicAttr;
            return this;
        }
        public java.util.List<GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr> getListGroupDynamicAttr() {
            return this.listGroupDynamicAttr;
        }

        public GroupQueryByOpenIdResponseBodyData setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
