<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusUpdateRenterMemberRequest extends Model
{
    /**
     * @description 扩展字段
     *
     * @var string
     */
    public $extend;

    /**
     * @description 名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 租客id
     *
     * @var int
     */
    public $renterId;

    /**
     * @description 类型
     *
     * @var string
     */
    public $type;

    /**
     * @description 人员唯一标识
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
