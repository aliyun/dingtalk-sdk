// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetEmpsByOrgIdResponseBody extends TeaModel {
    @NameInMap("empList")
    public java.util.List<GetEmpsByOrgIdResponseBodyEmpList> empList;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public Long nextToken;

    public static GetEmpsByOrgIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEmpsByOrgIdResponseBody self = new GetEmpsByOrgIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEmpsByOrgIdResponseBody setEmpList(java.util.List<GetEmpsByOrgIdResponseBodyEmpList> empList) {
        this.empList = empList;
        return this;
    }
    public java.util.List<GetEmpsByOrgIdResponseBodyEmpList> getEmpList() {
        return this.empList;
    }

    public GetEmpsByOrgIdResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetEmpsByOrgIdResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class GetEmpsByOrgIdResponseBodyEmpList extends TeaModel {
        @NameInMap("avatar")
        public String avatar;

        @NameInMap("dept_id_list")
        public java.util.List<Long> deptIdList;

        @NameInMap("dingId")
        public String dingId;

        @NameInMap("name")
        public String name;

        @NameInMap("nick")
        public String nick;

        @NameInMap("orgId")
        public Long orgId;

        @NameInMap("position")
        public String position;

        @NameInMap("unionid")
        public String unionid;

        @NameInMap("userid")
        public String userid;

        public static GetEmpsByOrgIdResponseBodyEmpList build(java.util.Map<String, ?> map) throws Exception {
            GetEmpsByOrgIdResponseBodyEmpList self = new GetEmpsByOrgIdResponseBodyEmpList();
            return TeaModel.build(map, self);
        }

        public GetEmpsByOrgIdResponseBodyEmpList setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public GetEmpsByOrgIdResponseBodyEmpList setDeptIdList(java.util.List<Long> deptIdList) {
            this.deptIdList = deptIdList;
            return this;
        }
        public java.util.List<Long> getDeptIdList() {
            return this.deptIdList;
        }

        public GetEmpsByOrgIdResponseBodyEmpList setDingId(String dingId) {
            this.dingId = dingId;
            return this;
        }
        public String getDingId() {
            return this.dingId;
        }

        public GetEmpsByOrgIdResponseBodyEmpList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetEmpsByOrgIdResponseBodyEmpList setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public GetEmpsByOrgIdResponseBodyEmpList setOrgId(Long orgId) {
            this.orgId = orgId;
            return this;
        }
        public Long getOrgId() {
            return this.orgId;
        }

        public GetEmpsByOrgIdResponseBodyEmpList setPosition(String position) {
            this.position = position;
            return this;
        }
        public String getPosition() {
            return this.position;
        }

        public GetEmpsByOrgIdResponseBodyEmpList setUnionid(String unionid) {
            this.unionid = unionid;
            return this;
        }
        public String getUnionid() {
            return this.unionid;
        }

        public GetEmpsByOrgIdResponseBodyEmpList setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

}
