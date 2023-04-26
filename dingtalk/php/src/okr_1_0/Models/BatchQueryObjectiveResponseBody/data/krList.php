<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryObjectiveResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchQueryObjectiveResponseBody\data\krList\progress;
use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class krList extends Model
{
    /**
     * @example 你好
     *
     * @var Stream
     */
    public $content;

    /**
     * @example 1648625407694
     *
     * @var float
     */
    public $gmtCreate;

    /**
     * @example 1648625407694
     *
     * @var float
     */
    public $gmtModified;

    /**
     * @example 5w9f
     *
     * @var Stream
     */
    public $id;

    /**
     * @example 5wf8
     *
     * @var Stream
     */
    public $objectiveId;

    /**
     * @var float[]
     */
    public $permission;

    /**
     * @example 35614536
     *
     * @var int
     */
    public $position;

    /**
     * @var progress
     */
    public $progress;

    /**
     * @example 44
     *
     * @var float
     */
    public $score;

    /**
     * @example 44
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
