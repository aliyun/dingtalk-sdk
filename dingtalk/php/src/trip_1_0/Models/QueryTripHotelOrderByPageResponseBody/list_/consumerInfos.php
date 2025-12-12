<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripHotelOrderByPageResponseBody\list_;

use AlibabaCloud\Tea\Model;

class consumerInfos extends Model
{
    /**
     * @var string
     */
    public $name;

    /**
     * @var bool
     */
    public $staffFlag;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'name' => 'name',
        'staffFlag' => 'staffFlag',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->staffFlag) {
            $res['staffFlag'] = $this->staffFlag;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return consumerInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['staffFlag'])) {
            $model->staffFlag = $map['staffFlag'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
