<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UserGroupAddStaticGroupMembersRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $groupCode;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'groupCode' => 'groupCode',
        'userIds' => 'userIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupCode) {
            $res['groupCode'] = $this->groupCode;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UserGroupAddStaticGroupMembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupCode'])) {
            $model->groupCode = $map['groupCode'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
