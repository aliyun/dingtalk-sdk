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
     * @var Stream[]
     */
    public $alignFromIds;

    /**
     * @var Stream[]
     */
    public $alignToIds;

    /**
     * @var Stream
     */
    public $content;

    /**
     * @var Stream
     */
    public $id;

    /**
     * @var krList[]
     */
    public $krList;

    /**
     * @var owner
     */
    public $owner;

    /**
     * @var Stream
     */
    public $periodId;

    /**
     * @var float[]
     */
    public $permission;

    /**
     * @var int
     */
    public $position;

    /**
     * @var progress
     */
    public $progress;

    /**
     * @var float
     */
    public $progressPercent;

    /**
     * @var bool
     */
    public $published;

    /**
     * @var float
     */
    public $score;

    /**
     * @var int
     */
    public $status;

    /**
     * @var Stream
     */
    public $userId;

    /**
     * @var float
     */
    public $weight;
    protected $_name = [
        'alignFromIds'    => 'alignFromIds',
        'alignToIds'      => 'alignToIds',
        'content'         => 'content',
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
