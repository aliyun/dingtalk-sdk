// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class GetUserOkrResponseBody extends TeaModel {
    /**
     * <p>data</p>
     */
    @NameInMap("data")
    public GetUserOkrResponseBodyData data;

    /**
     * <p>请求成功的标识。</p>
     */
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
        /**
         * <p>百分比。</p>
         */
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
        /**
         * <p>KR 内容。</p>
         */
        @NameInMap("content")
        public java.io.InputStream content;

        /**
         * <p>创建时间。时间戳</p>
         */
        @NameInMap("gmtCreate")
        public Float gmtCreate;

        /**
         * <p>更新时间。时间戳</p>
         */
        @NameInMap("gmtModified")
        public Float gmtModified;

        /**
         * <p>KR 的 ID。</p>
         */
        @NameInMap("id")
        public java.io.InputStream id;

        /**
         * <p>所属 Objective ID。</p>
         */
        @NameInMap("objectiveId")
        public java.io.InputStream objectiveId;

        /**
         * <p>KR 权限。</p>
         */
        @NameInMap("permission")
        public java.util.List<Float> permission;

        /**
         * <p>所处位置。</p>
         */
        @NameInMap("position")
        public Long position;

        /**
         * <p>KR 进度。</p>
         */
        @NameInMap("progress")
        public GetUserOkrResponseBodyDataListKrListProgress progress;

        /**
         * <p>所占分数。</p>
         */
        @NameInMap("score")
        public Float score;

        /**
         * <p>所占权重。</p>
         */
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
        /**
         * <p>所属者头像。 ID</p>
         */
        @NameInMap("avatarMediaId")
        public java.io.InputStream avatarMediaId;

        /**
         * <p>所属者组织 I。D</p>
         */
        @NameInMap("corpId")
        public java.io.InputStream corpId;

        /**
         * <p>所属者 OKR 系统中的 ID。</p>
         */
        @NameInMap("id")
        public java.io.InputStream id;

        /**
         * <p>所属者昵称。</p>
         */
        @NameInMap("nickname")
        public java.io.InputStream nickname;

        /**
         * <p>所属者 userId。</p>
         */
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
        /**
         * <p>百分比。</p>
         */
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
        /**
         * <p>被对齐的 Objective。</p>
         */
        @NameInMap("alignFromIds")
        public java.util.List<java.io.InputStream> alignFromIds;

        /**
         * <p>对齐的 Objective。</p>
         */
        @NameInMap("alignToIds")
        public java.util.List<java.io.InputStream> alignToIds;

        /**
         * <p>Objective 内容。</p>
         */
        @NameInMap("content")
        public java.io.InputStream content;

        /**
         * <p>创建时间。时间戳</p>
         */
        @NameInMap("gmtCreate")
        public Float gmtCreate;

        /**
         * <p>更新时间。时间戳</p>
         */
        @NameInMap("gmtModified")
        public Float gmtModified;

        /**
         * <p>objective。</p>
         */
        @NameInMap("id")
        public java.io.InputStream id;

        /**
         * <p>KR 详情列表。</p>
         */
        @NameInMap("krList")
        public java.util.List<GetUserOkrResponseBodyDataListKrList> krList;

        /**
         * <p>所属者信息。</p>
         */
        @NameInMap("owner")
        public GetUserOkrResponseBodyDataListOwner owner;

        /**
         * <p>周期 ID。</p>
         */
        @NameInMap("periodId")
        public java.io.InputStream periodId;

        /**
         * <p>权限值。</p>
         */
        @NameInMap("permission")
        public java.util.List<Float> permission;

        /**
         * <p>所在位置。</p>
         */
        @NameInMap("position")
        public Integer position;

        /**
         * <p>进度值。</p>
         */
        @NameInMap("progress")
        public GetUserOkrResponseBodyDataListProgress progress;

        /**
         * <p>百分比值。</p>
         */
        @NameInMap("progressPercent")
        public Float progressPercent;

        /**
         * <p>是否已发布。</p>
         */
        @NameInMap("published")
        public Boolean published;

        /**
         * <p>分数值。</p>
         */
        @NameInMap("score")
        public Float score;

        /**
         * <p>当前内容状态。</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>用户 ID。</p>
         */
        @NameInMap("userId")
        public java.io.InputStream userId;

        /**
         * <p>权重值。</p>
         */
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
        /**
         * <p>OKR 列表详情。</p>
         */
        @NameInMap("list")
        public java.util.List<GetUserOkrResponseBodyDataList> list;

        /**
         * <p>当前页码。</p>
         */
        @NameInMap("pageNumber")
        public Long pageNumber;

        /**
         * <p>每一页的个数。</p>
         */
        @NameInMap("pageSize")
        public Long pageSize;

        /**
         * <p>总数。</p>
         */
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
