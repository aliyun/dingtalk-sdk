<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateKROfWeightRequest extends Model
{
    /**
     * @description 权重比。
     *
     * @var int
     */
    public $weight;

    /**
     * @description 当前 KR ID。
     *
     * @var string
     */
    public $krId;

    /**
     * @description 当前用户的userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'weight' => 'weight',
        'krId'   => 'krId',
        'userId' => 'userId',
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
