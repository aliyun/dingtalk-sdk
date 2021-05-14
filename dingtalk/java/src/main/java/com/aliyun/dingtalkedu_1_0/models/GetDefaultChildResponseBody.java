// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetDefaultChildResponseBody extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("nick")
    public String nick;

    @NameInMap("avatar")
    public String avatar;

    @NameInMap("unionId")
    public String unionId;

    @NameInMap("period")
    public String period;

    @NameInMap("grade")
    public Integer grade;

    @NameInMap("bindStudents")
    public java.util.List<GetDefaultChildResponseBodyBindStudents> bindStudents;

    public static GetDefaultChildResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDefaultChildResponseBody self = new GetDefaultChildResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDefaultChildResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetDefaultChildResponseBody setNick(String nick) {
        this.nick = nick;
        return this;
    }
    public String getNick() {
        return this.nick;
    }

    public GetDefaultChildResponseBody setAvatar(String avatar) {
        this.avatar = avatar;
        return this;
    }
    public String getAvatar() {
        return this.avatar;
    }

    public GetDefaultChildResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetDefaultChildResponseBody setPeriod(String period) {
        this.period = period;
        return this;
    }
    public String getPeriod() {
        return this.period;
    }

    public GetDefaultChildResponseBody setGrade(Integer grade) {
        this.grade = grade;
        return this;
    }
    public Integer getGrade() {
        return this.grade;
    }

    public GetDefaultChildResponseBody setBindStudents(java.util.List<GetDefaultChildResponseBodyBindStudents> bindStudents) {
        this.bindStudents = bindStudents;
        return this;
    }
    public java.util.List<GetDefaultChildResponseBodyBindStudents> getBindStudents() {
        return this.bindStudents;
    }

    public static class GetDefaultChildResponseBodyBindStudents extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("staffId")
        public String staffId;

        @NameInMap("classId")
        public Long classId;

        @NameInMap("period")
        public String period;

        public static GetDefaultChildResponseBodyBindStudents build(java.util.Map<String, ?> map) throws Exception {
            GetDefaultChildResponseBodyBindStudents self = new GetDefaultChildResponseBodyBindStudents();
            return TeaModel.build(map, self);
        }

        public GetDefaultChildResponseBodyBindStudents setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetDefaultChildResponseBodyBindStudents setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

        public GetDefaultChildResponseBodyBindStudents setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public GetDefaultChildResponseBodyBindStudents setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

    }

}
