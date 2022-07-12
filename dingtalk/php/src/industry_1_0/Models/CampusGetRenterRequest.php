<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusGetRenterRequest extends Model
{
    /**
     * @description 租客ID
     *
     * @var int
     */
    public $renterId;
    protected $_name = [
        'renterId' => 'renterId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->renterId) {
            $res['renterId'] = $this->renterId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusGetRenterRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['renterId'])) {
            $model->renterId = $map['renterId'];
        }

        return $model;
    }
}