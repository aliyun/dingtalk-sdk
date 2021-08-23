<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody;

use AlibabaCloud\Tea\Model;

class roleList extends Model
{
    /**
     * @description 角色id
     *
     * @var int
     */
    public $id;

    /**
     * @description 角色名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 角色组名称
     *
     * @var string
     */
    public $groupName;
    protected $_name = [
        'id'        => 'id',
        'name'      => 'name',
        'groupName' => 'groupName',
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
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roleList
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
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }

        return $model;
    }
}
