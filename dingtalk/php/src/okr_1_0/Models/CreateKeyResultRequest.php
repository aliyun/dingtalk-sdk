<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class CreateKeyResultRequest extends Model
{
    /**
     * @var Stream
     */
    public $content;

    /**
     * @var Stream
     */
    public $objectiveId;

    /**
     * @var Stream
     */
    public $periodId;

    /**
     * @var int
     */
    public $prevPosition;

    /**
     * @var int
     */
    public $weight;

    /**
     * @var Stream
     */
    public $ownerId;
    protected $_name = [
        'content'      => 'content',
        'objectiveId'  => 'objectiveId',
        'periodId'     => 'periodId',
        'prevPosition' => 'prevPosition',
        'weight'       => 'weight',
        'ownerId'      => 'ownerId',
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
        if (null !== $this->ownerId) {
            $res['ownerId'] = $this->ownerId;
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
        if (isset($map['ownerId'])) {
            $model->ownerId = $map['ownerId'];
        }

        return $model;
    }
}
