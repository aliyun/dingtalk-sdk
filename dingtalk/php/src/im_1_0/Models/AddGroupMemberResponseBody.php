<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddGroupMemberResponseBody extends Model
{
    /**
     * @description 添加成功的钉外账号列表。
     *
     * @var string[]
     */
    public $appUserIds;

    /**
     * @description 添加成功的钉内账号列表。
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'appUserIds' => 'appUserIds',
        'userIds'    => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserIds) {
            $res['appUserIds'] = $this->appUserIds;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddGroupMemberResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserIds'])) {
            if (!empty($map['appUserIds'])) {
                $model->appUserIds = $map['appUserIds'];
            }
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
