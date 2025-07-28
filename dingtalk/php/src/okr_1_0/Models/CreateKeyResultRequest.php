<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateKeyResultRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 我的内容
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @example 58Y4
     *
     * @var string
     */
    public $objectiveId;

    /**
     * @description This parameter is required.
     *
     * @example 1006
     *
     * @var string
     */
    public $periodId;

    /**
     * @example 234631
     *
     * @var int
     */
    public $prevPosition;

    /**
     * @example 100
     *
     * @var int
     */
    public $weight;

    /**
     * @description This parameter is required.
     *
     * @example 06186238011033616
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'content' => 'content',
        'objectiveId' => 'objectiveId',
        'periodId' => 'periodId',
        'prevPosition' => 'prevPosition',
        'weight' => 'weight',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }
        if (null !== $this->prevPosition) {
            $res['prevPosition'] = $this->prevPosition;
        }
        if (null !== $this->weight) {
            $res['weight'] = $this->weight;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateKeyResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }
        if (isset($map['prevPosition'])) {
            $model->prevPosition = $map['prevPosition'];
        }
        if (isset($map['weight'])) {
            $model->weight = $map['weight'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
