<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusAddRenterMemberRequest extends Model
{
    /**
     * @example {"age":8}
     *
     * @var string
     */
    public $extend;

    /**
     * @example 158********
     *
     * @var string
     */
    public $mobile;

    /**
     * @example 张三组
     *
     * @var string
     */
    public $name;

    /**
     * @example 612355
     *
     * @var int
     */
    public $renterId;

    /**
     * @example admin
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'extend'   => 'extend',
        'mobile'   => 'mobile',
        'name'     => 'name',
        'renterId' => 'renterId',
        'type'     => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->renterId) {
            $res['renterId'] = $this->renterId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusAddRenterMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['renterId'])) {
            $model->renterId = $map['renterId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
