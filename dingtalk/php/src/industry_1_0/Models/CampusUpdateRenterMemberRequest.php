<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusUpdateRenterMemberRequest extends Model
{
    /**
     * @example 扩展
     *
     * @var string
     */
    public $extend;

    /**
     * @example 张三组
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 41239123
     *
     * @var int
     */
    public $renterId;

    /**
     * @example 1
     *
     * @var string
     */
    public $type;

    /**
     * @description This parameter is required.
     *
     * @example fksif91273
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'extend'   => 'extend',
        'name'     => 'name',
        'renterId' => 'renterId',
        'type'     => 'type',
        'unionId'  => 'unionId',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->renterId) {
            $res['renterId'] = $this->renterId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusUpdateRenterMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
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
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
