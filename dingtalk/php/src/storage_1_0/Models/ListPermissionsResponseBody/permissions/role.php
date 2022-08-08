<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListPermissionsResponseBody\permissions;

use AlibabaCloud\Tea\Model;

class role extends Model
{
    /**
     * @description 角色id
     *
     * @var string
     */
    public $id;

    /**
     * @description 角色名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'id'   => 'id',
        'name' => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return role
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
