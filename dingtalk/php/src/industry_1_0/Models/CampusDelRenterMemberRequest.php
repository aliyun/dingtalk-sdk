<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusDelRenterMemberRequest extends Model
{
    /**
     * @example 124353123
     *
     * @var int
     */
    public $renterId;

    /**
     * @example kindg****
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'renterId' => 'renterId',
        'unionId'  => 'unionId',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusDelRenterMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['renterId'])) {
            $model->renterId = $map['renterId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
