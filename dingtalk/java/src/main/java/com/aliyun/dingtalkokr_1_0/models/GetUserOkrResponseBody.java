// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class GetUserOkrResponseBody extends TeaModel {
    // data
    @NameInMap("data")
    public GetUserOkrResponseBodyData data;

    // 请求成功的标识。
    @NameInMap("success")
    public Boolean success;

    public static GetUserOkrResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserOkrResponseBody self = new GetUserOkrResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserOkrResponseBody setData(GetUserOkrResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetUserOkrResponseBodyData getData() {
        return this.data;
    }

    public GetUserOkrResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetUserOkrResponseBodyDataListKrListProgress extends TeaModel {
        // 百分比。
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
        // KR 内容。
        @NameInMap("content")
        public java.io.InputStream content;

        // 创建时间。时间戳
        @NameInMap("gmtCreate")
        public Float gmtCreate;

        // 更新时间。时间戳
        @NameInMap("gmtModified")
        public Float gmtModified;

        // KR 的 ID。
        @NameInMap("id")
        public java.io.InputStream id;

        // 所属 Objective ID。
        @NameInMap("objectiveId")
        public java.io.InputStream objectiveId;

        // KR 权限。
        @NameInMap("permission")
        public java.util.List<Float> permission;

        // 所处位置。
        @NameInMap("position")
        public Long position;

        // KR 进度。
        @NameInMap("progress")
        public GetUserOkrResponseBodyDataListKrListProgress progress;

        // 所占分数。
        @NameInMap("score")
        public Float score;

        // 所占权重。
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

        public GetUserOkrResponseBodyDataListKrList setGmtCreate(Float gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Float getGmtCreate() {
            return this.gmtCreate;
        }

        public GetUserOkrResponseBodyDataListKrList setGmtModified(Float gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Float getGmtModified() {
            return this.gmtModified;
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

    public static class GetUserOkrResponseBodyDataListOwner extends TeaModel {
        // 所属者头像。 ID
        @NameInMap("avatarMediaId")
        public java.io.InputStream avatarMediaId;

        // 所属者组织 I。D
        @NameInMap("corpId")
        public java.io.InputStream corpId;

        // 所属者 OKR 系统中的 ID。
        @NameInMap("id")
        public java.io.InputStream id;

        // 所属者昵称。
        @NameInMap("nickname")
        public java.io.InputStream nickname;

        // 所属者 userId。
        @NameInMap("userId")
        public java.io.InputStream userId;

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

        public GetUserOkrResponseBodyDataListOwner setUserId(java.io.InputStream userId) {
            this.userId = userId;
            return this;
        }
        public java.io.InputStream getUserId() {
            return this.userId;
        }

    }

    public static class GetUserOkrResponseBodyDataListProgress extends TeaModel {
        // 百分比。
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
        // 被对齐的 Objective。
        @NameInMap("alignFromIds")
        public java.util.List<java.io.InputStream> alignFromIds;

        // 对齐的 Objective。
        @NameInMap("alignToIds")
        public java.util.List<java.io.InputStream> alignToIds;

        // Objective 内容。
        @NameInMap("content")
        public java.io.InputStream content;

        // 创建时间。时间戳
        @NameInMap("gmtCreate")
        public Float gmtCreate;

        // 更新时间。时间戳
        @NameInMap("gmtModified")
        public Float gmtModified;

        // objective。
        @NameInMap("id")
        public java.io.InputStream id;

        // KR 详情列表。
        @NameInMap("krList")
        public java.util.List<GetUserOkrResponseBodyDataListKrList> krList;

        // 所属者信息。
        @NameInMap("owner")
        public GetUserOkrResponseBodyDataListOwner owner;

        // 周期 ID。
        @NameInMap("periodId")
        public java.io.InputStream periodId;

        // 权限值。
        @NameInMap("permission")
        public java.util.List<Float> permission;

        // 所在位置。
        @NameInMap("position")
        public Integer position;

        // 进度值。
        @NameInMap("progress")
        public GetUserOkrResponseBodyDataListProgress progress;

        // 百分比值。
        @NameInMap("progressPercent")
        public Float progressPercent;

        // 是否已发布。
        @NameInMap("published")
        public Boolean published;

        // 分数值。
        @NameInMap("score")
        public Float score;

        // 当前内容状态。
        @NameInMap("status")
        public Integer status;

        // 用户 ID。
        @NameInMap("userId")
        public java.io.InputStream userId;

        // 权重值。
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

        public GetUserOkrResponseBodyDataList setGmtCreate(Float gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Float getGmtCreate() {
            return this.gmtCreate;
        }

        public GetUserOkrResponseBodyDataList setGmtModified(Float gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Float getGmtModified() {
            return this.gmtModified;
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
        // OKR 列表详情。
        @NameInMap("list")
        public java.util.List<GetUserOkrResponseBodyDataList> list;

        // 当前页码。
        @NameInMap("pageNumber")
        public Long pageNumber;

        // 每一页的个数。
        @NameInMap("pageSize")
        public Long pageSize;

        // 总数。
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

        public GetUserOkrResponseBodyData setPageNumber(Long pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Long getPageNumber() {
            return this.pageNumber;
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
