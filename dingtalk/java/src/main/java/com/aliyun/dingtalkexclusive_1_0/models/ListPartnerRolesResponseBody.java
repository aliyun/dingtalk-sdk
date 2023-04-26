// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListPartnerRolesResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<ListPartnerRolesResponseBodyList> list;

    public static ListPartnerRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListPartnerRolesResponseBody self = new ListPartnerRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListPartnerRolesResponseBody setList(java.util.List<ListPartnerRolesResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListPartnerRolesResponseBodyList> getList() {
        return this.list;
    }

    public static class ListPartnerRolesResponseBodyListVisibleDepts extends TeaModel {
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("name")
        public String name;

        public static ListPartnerRolesResponseBodyListVisibleDepts build(java.util.Map<String, ?> map) throws Exception {
            ListPartnerRolesResponseBodyListVisibleDepts self = new ListPartnerRolesResponseBodyListVisibleDepts();
            return TeaModel.build(map, self);
        }

        public ListPartnerRolesResponseBodyListVisibleDepts setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public ListPartnerRolesResponseBodyListVisibleDepts setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class ListPartnerRolesResponseBodyListVisibleUsers extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static ListPartnerRolesResponseBodyListVisibleUsers build(java.util.Map<String, ?> map) throws Exception {
            ListPartnerRolesResponseBodyListVisibleUsers self = new ListPartnerRolesResponseBodyListVisibleUsers();
            return TeaModel.build(map, self);
        }

        public ListPartnerRolesResponseBodyListVisibleUsers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListPartnerRolesResponseBodyListVisibleUsers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListPartnerRolesResponseBodyListWarningDepts extends TeaModel {
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("name")
        public String name;

        public static ListPartnerRolesResponseBodyListWarningDepts build(java.util.Map<String, ?> map) throws Exception {
            ListPartnerRolesResponseBodyListWarningDepts self = new ListPartnerRolesResponseBodyListWarningDepts();
            return TeaModel.build(map, self);
        }

        public ListPartnerRolesResponseBodyListWarningDepts setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public ListPartnerRolesResponseBodyListWarningDepts setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class ListPartnerRolesResponseBodyListWarningUsers extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static ListPartnerRolesResponseBodyListWarningUsers build(java.util.Map<String, ?> map) throws Exception {
            ListPartnerRolesResponseBodyListWarningUsers self = new ListPartnerRolesResponseBodyListWarningUsers();
            return TeaModel.build(map, self);
        }

        public ListPartnerRolesResponseBodyListWarningUsers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListPartnerRolesResponseBodyListWarningUsers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListPartnerRolesResponseBodyList extends TeaModel {
        @NameInMap("id")
        public Long id;

        @NameInMap("isNecessary")
        public Integer isNecessary;

        @NameInMap("name")
        public String name;

        @NameInMap("visibleDepts")
        public java.util.List<ListPartnerRolesResponseBodyListVisibleDepts> visibleDepts;

        @NameInMap("visibleUsers")
        public java.util.List<ListPartnerRolesResponseBodyListVisibleUsers> visibleUsers;

        @NameInMap("warningDepts")
        public java.util.List<ListPartnerRolesResponseBodyListWarningDepts> warningDepts;

        @NameInMap("warningUsers")
        public java.util.List<ListPartnerRolesResponseBodyListWarningUsers> warningUsers;

        public static ListPartnerRolesResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListPartnerRolesResponseBodyList self = new ListPartnerRolesResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListPartnerRolesResponseBodyList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public ListPartnerRolesResponseBodyList setIsNecessary(Integer isNecessary) {
            this.isNecessary = isNecessary;
            return this;
        }
        public Integer getIsNecessary() {
            return this.isNecessary;
        }

        public ListPartnerRolesResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListPartnerRolesResponseBodyList setVisibleDepts(java.util.List<ListPartnerRolesResponseBodyListVisibleDepts> visibleDepts) {
            this.visibleDepts = visibleDepts;
            return this;
        }
        public java.util.List<ListPartnerRolesResponseBodyListVisibleDepts> getVisibleDepts() {
            return this.visibleDepts;
        }

        public ListPartnerRolesResponseBodyList setVisibleUsers(java.util.List<ListPartnerRolesResponseBodyListVisibleUsers> visibleUsers) {
            this.visibleUsers = visibleUsers;
            return this;
        }
        public java.util.List<ListPartnerRolesResponseBodyListVisibleUsers> getVisibleUsers() {
            return this.visibleUsers;
        }

        public ListPartnerRolesResponseBodyList setWarningDepts(java.util.List<ListPartnerRolesResponseBodyListWarningDepts> warningDepts) {
            this.warningDepts = warningDepts;
            return this;
        }
        public java.util.List<ListPartnerRolesResponseBodyListWarningDepts> getWarningDepts() {
            return this.warningDepts;
        }

        public ListPartnerRolesResponseBodyList setWarningUsers(java.util.List<ListPartnerRolesResponseBodyListWarningUsers> warningUsers) {
            this.warningUsers = warningUsers;
            return this;
        }
        public java.util.List<ListPartnerRolesResponseBodyListWarningUsers> getWarningUsers() {
            return this.warningUsers;
        }

    }

}
