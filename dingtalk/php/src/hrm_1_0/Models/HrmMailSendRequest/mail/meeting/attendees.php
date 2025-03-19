<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\mail\meeting;

use AlibabaCloud\Tea\Model;

class attendees extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example abc@aaa.com
     *
     * @var string
     */
    public $address;

    /**
     * @description This parameter is required.
     *
     * @example 参会人1
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'address' => 'address',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attendees
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
