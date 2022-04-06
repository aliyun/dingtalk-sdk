<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrResponseBody\data\list_\krList;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrResponseBody\data\list_\owner;
use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrResponseBody\data\list_\progress;
use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class list_ extends Model
{
    /**
     * @description 被对齐的 Objective。
     *
     * @var Stream[]
     */
    public $alignFromIds;

    /**
     * @description 对齐的 Objective。
     *
     * @var Stream[]
     */
    public $alignToIds;

    /**
     * @description Objective 内容。
     *
     * @var Stream
     */
    public $content;

    /**
     * @description 创建时间。时间戳
     *
     * @var float
     */
    public $gmtCreate;

    /**
     * @description 更新时间。时间戳
     *
     * @var float
     */
    public $gmtModified;

    /**
     * @description objective。
     *
     * @var Stream
     */
    public $id;

    /**
     * @description KR 详情列表。
     *
     * @var krList[]
     */
    public $krList;

    /**
     * @description 所属者信息。
     *
     * @var owner
     */
    public $owner;

    /**
     * @description 周期 ID。
     *
     * @var Stream
     */
    public $periodId;

    /**
     * @description 权限值。
     *
     * @var float[]
     */
    public $permission;

    /**
     * @description 所在位置。
     *
     * @var int
     */
    public $position;

    /**
     * @description 进度值。
     *
     * @var progress
     */
    public $progress;

    /**
     * @description 百分比值。
     *
     * @var float
     */
    public $progressPercent;

    /**
     * @description 是否已发布。
     *
     * @var bool
     */
    public $published;

    /**
     * @description 分数值。
     *
     * @var float
     */
    public $score;

    /**
     * @description 当前内容状态。
     *
     * @var int
     */
    public $status;

    /**
     * @description 用户 ID。
     *
     * @var Stream
     */
    public $userId;

    /**
     * @description 权重值。
     *
     * @var float
     */
    public $weight;
    protected $_name = [
        'alignFromIds'    => 'alignFromIds',
        'alignToIds'      => 'alignToIds',
        'content'         => 'content',
        'gmtCreate'       => 'gmtCreate',
        'gmtModified'     => 'gmtModified',
        'id'              => 'id',
        'krList'          => 'krList',
        'owner'           => 'owner',
        'periodId'        => 'periodId',
        'permission'      => 'permission',
        'position'        => 'position',
        'progress'        => 'progress',
        'progressPercent' => 'progressPercent',
        'published'       => 'published',
        'score'           => 'score',
        'status'          => 'status',
        'userId'          => 'userId',
        'weight'          => 'weight',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->alignFromIds) {
            $res['alignFromIds'] = $this->alignFromIds;
        }
        if (null !== $this->alignToIds) {
            $res['alignToIds'] = $this->alignToIds;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->krList) {
            $res['krList'] = [];
            if (null !== $this->krList && \is_array($this->krList)) {
                $n = 0;
                foreach ($this->krList as $item) {
                    $res['krList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->owner) {
            $res['owner'] = null !== $this->owner ? $this->owner->toMap() : null;
        }
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }
        if (null !== $this->permission) {
            $res['permission'] = $this->permission;
        }
        if (null !== $this->position) {
            $res['position'] = $this->position;
        }
        if (null !== $this->progress) {
            $res['progress'] = null !== $this->progress ? $this->progress->toMap() : null;
        }
        if (null !== $this->progressPercent) {
            $res['progressPercent'] = $this->progressPercent;
        }
        if (null !== $this->published) {
            $res['published'] = $this->published;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->weight) {
            $res['weight'] = $this->weight;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alignFromIds'])) {
            if (!empty($map['alignFromIds'])) {
                $model->alignFromIds = $map['alignFromIds'];
            }
        }
        if (isset($map['alignToIds'])) {
            if (!empty($map['alignToIds'])) {
                $model->alignToIds = $map['alignToIds'];
            }
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['krList'])) {
            if (!empty($map['krList'])) {
                $model->krList = [];
                $n             = 0;
                foreach ($map['krList'] as $item) {
                    $model->krList[$n++] = null !== $item ? krList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['owner'])) {
            $model->owner = owner::fromMap($map['owner']);
        }
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }
        if (isset($map['permission'])) {
            if (!empty($map['permission'])) {
                $model->permission = $map['permission'];
            }
        }
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }
        if (isset($map['progress'])) {
            $model->progress = progress::fromMap($map['progress']);
        }
        if (isset($map['progressPercent'])) {
            $model->progressPercent = $map['progressPercent'];
        }
        if (isset($map['published'])) {
            $model->published = $map['published'];
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['weight'])) {
            $model->weight = $map['weight'];
        }

        return $model;
    }
}
