<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusDelRenterMemberRequest extends Model
{
    /**
     * @description 租客唯一id
     *
     * @var int
     */
    public $renterId;

    /**
     * @description 人员唯一标识
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
