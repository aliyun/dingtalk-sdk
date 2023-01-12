<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublicDevicesResponseBody\data;

use AlibabaCloud\Tea\Model;

class deviceRoles extends Model
{
    /**
     * @description 角色名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 角色code
     *
     * @var string
     */
    public $tagCode;
    protected $_name = [
        'name'    => 'name',
        'tagCode' => 'tagCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deviceRoles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }

        return $model;
    }
}
