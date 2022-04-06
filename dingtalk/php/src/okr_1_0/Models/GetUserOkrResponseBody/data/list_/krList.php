<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrResponseBody\data\list_;

use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrResponseBody\data\list_\krList\progress;
use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class krList extends Model
{
    /**
     * @description KR 内容。
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
     * @description KR 的 ID。
     *
     * @var Stream
     */
    public $id;

    /**
     * @description 所属 Objective ID。
     *
     * @var Stream
     */
    public $objectiveId;

    /**
     * @description KR 权限。
     *
     * @var float[]
     */
    public $permission;

    /**
     * @description 所处位置。
     *
     * @var int
     */
    public $position;

    /**
     * @description KR 进度。
     *
     * @var progress
     */
    public $progress;

    /**
     * @description 所占分数。
     *
     * @var float
     */
    public $score;

    /**
     * @description 所占权重。
     *
     * @var float
     */
    public $weight;
    protected $_name = [
        'content'     => 'content',
        'gmtCreate'   => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'id'          => 'id',
        'objectiveId' => 'objectiveId',
        'permission'  => 'permission',
        'position'    => 'position',
        'progress'    => 'progress',
        'score'       => 'score',
        'weight'      => 'weight',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
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
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->weight) {
            $res['weight'] = $this->weight;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return krList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
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
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['weight'])) {
            $model->weight = $map['weight'];
        }

        return $model;
    }
}
