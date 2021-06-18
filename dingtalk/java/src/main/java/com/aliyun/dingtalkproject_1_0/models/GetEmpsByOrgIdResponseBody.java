// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetEmpsByOrgIdResponseBody extends TeaModel {
    // empList
    @NameInMap("empList")
    public java.util.List<GetEmpsByOrgIdResponseBodyEmpList> empList;

    // hasMore
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
        // dingId
        @NameInMap("dingId")
        public String dingId;

        // unionId
        @NameInMap("unionid")
        public String unionid;

        // name
        @NameInMap("name")
        public String name;

        // nick
        @NameInMap("nick")
        public String nick;

        // userid
        @NameInMap("userid")
        public String userid;

        // orgId
        @NameInMap("orgId")
        public Long orgId;

        // avatar
        @NameInMap("avatar")
        public String avatar;

        // deptIdList
        @NameInMap("dept_id_list")
        public java.util.List<Long> deptIdList;

        @NameInMap("position")
        public String position;

        public static GetEmpsByOrgIdResponseBodyEmpList build(java.util.Map<String, ?> map) throws Exception {
            GetEmpsByOrgIdResponseBodyEmpList self = new GetEmpsByOrgIdResponseBodyEmpList();
            return TeaModel.build(map, self);
        }

        public GetEmpsByOrgIdResponseBodyEmpList setDingId(String dingId) {
            this.dingId = dingId;
            return this;
        }
        public String getDingId() {
            return this.dingId;
        }

        public GetEmpsByOrgIdResponseBodyEmpList setUnionid(String unionid) {
            this.unionid = unionid;
            return this;
        }
        public String getUnionid() {
            return this.unionid;
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

        public GetEmpsByOrgIdResponseBodyEmpList setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

        public GetEmpsByOrgIdResponseBodyEmpList setOrgId(Long orgId) {
            this.orgId = orgId;
            return this;
        }
        public Long getOrgId() {
            return this.orgId;
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

        public GetEmpsByOrgIdResponseBodyEmpList setPosition(String position) {
            this.position = position;
            return this;
        }
        public String getPosition() {
            return this.position;
        }

    }

}
