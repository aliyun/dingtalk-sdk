<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class UpdateKROfWeightRequest extends Model
{
    /**
     * @var int
     */
    public $weight;

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
        'weight'  => 'weight',
        'krId'    => 'krId',
        'ownerId' => 'ownerId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->weight) {
            $res['weight'] = $this->weight;
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
     * @return UpdateKROfWeightRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['weight'])) {
            $model->weight = $map['weight'];
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
