<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class UpdateKROfScoreRequest extends Model
{
    /**
     * @var int
     */
    public $score;

    /**
     * @description A short description of struct
     *
     * @var Stream
     */
    public $krId;

    /**
     * @var Stream
     */
    public $ownerId;
    protected $_name = [
        'score'   => 'score',
        'krId'    => 'krId',
        'ownerId' => 'ownerId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->krId) {
            $res['krId'] = $this->krId;
        }
        if (null !== $this->ownerId) {
            $res['ownerId'] = $this->ownerId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateKROfScoreRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['krId'])) {
            $model->krId = $map['krId'];
        }
        if (isset($map['ownerId'])) {
            $model->ownerId = $map['ownerId'];
        }

        return $model;
    }
}
