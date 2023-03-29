<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUpdateAuthInfoRequest\updateUserList;

use AlibabaCloud\Tea\Model;

class roleList extends Model
{
    /**
     * @var string
     */
    public $roleName;

    /**
     * @var int
     */
    public $sourceRoleId;
    protected $_name = [
        'roleName'     => 'roleName',
        'sourceRoleId' => 'sourceRoleId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }
        if (null !== $this->sourceRoleId) {
            $res['sourceRoleId'] = $this->sourceRoleId;
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
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }
        if (isset($map['sourceRoleId'])) {
            $model->sourceRoleId = $map['sourceRoleId'];
        }

        return $model;
    }
}
