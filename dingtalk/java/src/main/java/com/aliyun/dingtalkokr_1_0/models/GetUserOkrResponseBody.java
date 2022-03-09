// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class GetUserOkrResponseBody extends TeaModel {
    // code
    @NameInMap("code")
    public Long code;

    // data
    @NameInMap("data")
    public GetUserOkrResponseBodyData data;

    // message
    @NameInMap("message")
    public java.io.InputStream message;

    // success
    @NameInMap("success")
    public Boolean success;

    public static GetUserOkrResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserOkrResponseBody self = new GetUserOkrResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserOkrResponseBody setCode(Long code) {
        this.code = code;
        return this;
    }
    public Long getCode() {
        return this.code;
    }

    public GetUserOkrResponseBody setData(GetUserOkrResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetUserOkrResponseBodyData getData() {
        return this.data;
    }

    public GetUserOkrResponseBody setMessage(java.io.InputStream message) {
        this.message = message;
        return this;
    }
    public java.io.InputStream getMessage() {
        return this.message;
    }

    public GetUserOkrResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetUserOkrResponseBodyDataListKrListProgress extends TeaModel {
        @NameInMap("percent")
        public Integer percent;

        public static GetUserOkrResponseBodyDataListKrListProgress build(java.util.Map<String, ?> map) throws Exception {
            GetUserOkrResponseBodyDataListKrListProgress self = new GetUserOkrResponseBodyDataListKrListProgress();
            return TeaModel.build(map, self);
        }

        public GetUserOkrResponseBodyDataListKrListProgress setPercent(Integer percent) {
            this.percent = percent;
            return this;
        }
        public Integer getPercent() {
            return this.percent;
        }

    }

    public static class GetUserOkrResponseBodyDataListKrList extends TeaModel {
        @NameInMap("content")
        public java.io.InputStream content;

        @NameInMap("id")
        public java.io.InputStream id;

        @NameInMap("objectiveId")
        public java.io.InputStream objectiveId;

        @NameInMap("permission")
        public java.util.List<Float> permission;

        @NameInMap("position")
        public Long position;

        @NameInMap("progress")
        public GetUserOkrResponseBodyDataListKrListProgress progress;

        @NameInMap("score")
        public Float score;

        @NameInMap("weight")
        public Float weight;

        public static GetUserOkrResponseBodyDataListKrList build(java.util.Map<String, ?> map) throws Exception {
            GetUserOkrResponseBodyDataListKrList self = new GetUserOkrResponseBodyDataListKrList();
            return TeaModel.build(map, self);
        }

        public GetUserOkrResponseBodyDataListKrList setContent(java.io.InputStream content) {
            this.content = content;
            return this;
        }
        public java.io.InputStream getContent() {
            return this.content;
        }

        public GetUserOkrResponseBodyDataListKrList setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public GetUserOkrResponseBodyDataListKrList setObjectiveId(java.io.InputStream objectiveId) {
            this.objectiveId = objectiveId;
            return this;
        }
        public java.io.InputStream getObjectiveId() {
            return this.objectiveId;
        }

        public GetUserOkrResponseBodyDataListKrList setPermission(java.util.List<Float> permission) {
            this.permission = permission;
            return this;
        }
        public java.util.List<Float> getPermission() {
            return this.permission;
        }

        public GetUserOkrResponseBodyDataListKrList setPosition(Long position) {
            this.position = position;
            return this;
        }
        public Long getPosition() {
            return this.position;
        }

        public GetUserOkrResponseBodyDataListKrList setProgress(GetUserOkrResponseBodyDataListKrListProgress progress) {
            this.progress = progress;
            return this;
        }
        public GetUserOkrResponseBodyDataListKrListProgress getProgress() {
            return this.progress;
        }

        public GetUserOkrResponseBodyDataListKrList setScore(Float score) {
            this.score = score;
            return this;
        }
        public Float getScore() {
            return this.score;
        }

        public GetUserOkrResponseBodyDataListKrList setWeight(Float weight) {
            this.weight = weight;
            return this;
        }
        public Float getWeight() {
            return this.weight;
        }

    }

    public static class GetUserOkrResponseBodyDataListOwnerDepartment extends TeaModel {
        @NameInMap("id")
        public java.io.InputStream id;

        @NameInMap("name")
        public java.io.InputStream name;

        public static GetUserOkrResponseBodyDataListOwnerDepartment build(java.util.Map<String, ?> map) throws Exception {
            GetUserOkrResponseBodyDataListOwnerDepartment self = new GetUserOkrResponseBodyDataListOwnerDepartment();
            return TeaModel.build(map, self);
        }

        public GetUserOkrResponseBodyDataListOwnerDepartment setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public GetUserOkrResponseBodyDataListOwnerDepartment setName(java.io.InputStream name) {
            this.name = name;
            return this;
        }
        public java.io.InputStream getName() {
            return this.name;
        }

    }

    public static class GetUserOkrResponseBodyDataListOwner extends TeaModel {
        @NameInMap("avatarMediaId")
        public java.io.InputStream avatarMediaId;

        @NameInMap("corpId")
        public java.io.InputStream corpId;

        @NameInMap("department")
        public GetUserOkrResponseBodyDataListOwnerDepartment department;

        @NameInMap("id")
        public java.io.InputStream id;

        @NameInMap("nickname")
        public java.io.InputStream nickname;

        @NameInMap("staffId")
        public java.io.InputStream staffId;

        public static GetUserOkrResponseBodyDataListOwner build(java.util.Map<String, ?> map) throws Exception {
            GetUserOkrResponseBodyDataListOwner self = new GetUserOkrResponseBodyDataListOwner();
            return TeaModel.build(map, self);
        }

        public GetUserOkrResponseBodyDataListOwner setAvatarMediaId(java.io.InputStream avatarMediaId) {
            this.avatarMediaId = avatarMediaId;
            return this;
        }
        public java.io.InputStream getAvatarMediaId() {
            return this.avatarMediaId;
        }

        public GetUserOkrResponseBodyDataListOwner setCorpId(java.io.InputStream corpId) {
            this.corpId = corpId;
            return this;
        }
        public java.io.InputStream getCorpId() {
            return this.corpId;
        }

        public GetUserOkrResponseBodyDataListOwner setDepartment(GetUserOkrResponseBodyDataListOwnerDepartment department) {
            this.department = department;
            return this;
        }
        public GetUserOkrResponseBodyDataListOwnerDepartment getDepartment() {
            return this.department;
        }

        public GetUserOkrResponseBodyDataListOwner setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public GetUserOkrResponseBodyDataListOwner setNickname(java.io.InputStream nickname) {
            this.nickname = nickname;
            return this;
        }
        public java.io.InputStream getNickname() {
            return this.nickname;
        }

        public GetUserOkrResponseBodyDataListOwner setStaffId(java.io.InputStream staffId) {
            this.staffId = staffId;
            return this;
        }
        public java.io.InputStream getStaffId() {
            return this.staffId;
        }

    }

    public static class GetUserOkrResponseBodyDataListProgress extends TeaModel {
        @NameInMap("percent")
        public Integer percent;

        public static GetUserOkrResponseBodyDataListProgress build(java.util.Map<String, ?> map) throws Exception {
            GetUserOkrResponseBodyDataListProgress self = new GetUserOkrResponseBodyDataListProgress();
            return TeaModel.build(map, self);
        }

        public GetUserOkrResponseBodyDataListProgress setPercent(Integer percent) {
            this.percent = percent;
            return this;
        }
        public Integer getPercent() {
            return this.percent;
        }

    }

    public static class GetUserOkrResponseBodyDataList extends TeaModel {
        @NameInMap("alignFromIds")
        public java.util.List<java.io.InputStream> alignFromIds;

        @NameInMap("alignToIds")
        public java.util.List<java.io.InputStream> alignToIds;

        @NameInMap("content")
        public java.io.InputStream content;

        @NameInMap("id")
        public java.io.InputStream id;

        @NameInMap("krList")
        public java.util.List<GetUserOkrResponseBodyDataListKrList> krList;

        @NameInMap("owner")
        public GetUserOkrResponseBodyDataListOwner owner;

        @NameInMap("periodId")
        public java.io.InputStream periodId;

        @NameInMap("permission")
        public java.util.List<Float> permission;

        @NameInMap("position")
        public Integer position;

        @NameInMap("progress")
        public GetUserOkrResponseBodyDataListProgress progress;

        @NameInMap("progressPercent")
        public Float progressPercent;

        @NameInMap("published")
        public Boolean published;

        @NameInMap("score")
        public Float score;

        @NameInMap("status")
        public Integer status;

        @NameInMap("userId")
        public java.io.InputStream userId;

        @NameInMap("weight")
        public Float weight;

        public static GetUserOkrResponseBodyDataList build(java.util.Map<String, ?> map) throws Exception {
            GetUserOkrResponseBodyDataList self = new GetUserOkrResponseBodyDataList();
            return TeaModel.build(map, self);
        }

        public GetUserOkrResponseBodyDataList setAlignFromIds(java.util.List<java.io.InputStream> alignFromIds) {
            this.alignFromIds = alignFromIds;
            return this;
        }
        public java.util.List<java.io.InputStream> getAlignFromIds() {
            return this.alignFromIds;
        }

        public GetUserOkrResponseBodyDataList setAlignToIds(java.util.List<java.io.InputStream> alignToIds) {
            this.alignToIds = alignToIds;
            return this;
        }
        public java.util.List<java.io.InputStream> getAlignToIds() {
            return this.alignToIds;
        }

        public GetUserOkrResponseBodyDataList setContent(java.io.InputStream content) {
            this.content = content;
            return this;
        }
        public java.io.InputStream getContent() {
            return this.content;
        }

        public GetUserOkrResponseBodyDataList setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public GetUserOkrResponseBodyDataList setKrList(java.util.List<GetUserOkrResponseBodyDataListKrList> krList) {
            this.krList = krList;
            return this;
        }
        public java.util.List<GetUserOkrResponseBodyDataListKrList> getKrList() {
            return this.krList;
        }

        public GetUserOkrResponseBodyDataList setOwner(GetUserOkrResponseBodyDataListOwner owner) {
            this.owner = owner;
            return this;
        }
        public GetUserOkrResponseBodyDataListOwner getOwner() {
            return this.owner;
        }

        public GetUserOkrResponseBodyDataList setPeriodId(java.io.InputStream periodId) {
            this.periodId = periodId;
            return this;
        }
        public java.io.InputStream getPeriodId() {
            return this.periodId;
        }

        public GetUserOkrResponseBodyDataList setPermission(java.util.List<Float> permission) {
            this.permission = permission;
            return this;
        }
        public java.util.List<Float> getPermission() {
            return this.permission;
        }

        public GetUserOkrResponseBodyDataList setPosition(Integer position) {
            this.position = position;
            return this;
        }
        public Integer getPosition() {
            return this.position;
        }

        public GetUserOkrResponseBodyDataList setProgress(GetUserOkrResponseBodyDataListProgress progress) {
            this.progress = progress;
            return this;
        }
        public GetUserOkrResponseBodyDataListProgress getProgress() {
            return this.progress;
        }

        public GetUserOkrResponseBodyDataList setProgressPercent(Float progressPercent) {
            this.progressPercent = progressPercent;
            return this;
        }
        public Float getProgressPercent() {
            return this.progressPercent;
        }

        public GetUserOkrResponseBodyDataList setPublished(Boolean published) {
            this.published = published;
            return this;
        }
        public Boolean getPublished() {
            return this.published;
        }

        public GetUserOkrResponseBodyDataList setScore(Float score) {
            this.score = score;
            return this;
        }
        public Float getScore() {
            return this.score;
        }

        public GetUserOkrResponseBodyDataList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public GetUserOkrResponseBodyDataList setUserId(java.io.InputStream userId) {
            this.userId = userId;
            return this;
        }
        public java.io.InputStream getUserId() {
            return this.userId;
        }

        public GetUserOkrResponseBodyDataList setWeight(Float weight) {
            this.weight = weight;
            return this;
        }
        public Float getWeight() {
            return this.weight;
        }

    }

    public static class GetUserOkrResponseBodyData extends TeaModel {
        @NameInMap("list")
        public java.util.List<GetUserOkrResponseBodyDataList> list;

        @NameInMap("pageNo")
        public Long pageNo;

        @NameInMap("pageSize")
        public Long pageSize;

        @NameInMap("totalCount")
        public Long totalCount;

        public static GetUserOkrResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetUserOkrResponseBodyData self = new GetUserOkrResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetUserOkrResponseBodyData setList(java.util.List<GetUserOkrResponseBodyDataList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<GetUserOkrResponseBodyDataList> getList() {
            return this.list;
        }

        public GetUserOkrResponseBodyData setPageNo(Long pageNo) {
            this.pageNo = pageNo;
            return this;
        }
        public Long getPageNo() {
            return this.pageNo;
        }

        public GetUserOkrResponseBodyData setPageSize(Long pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Long getPageSize() {
            return this.pageSize;
        }

        public GetUserOkrResponseBodyData setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
