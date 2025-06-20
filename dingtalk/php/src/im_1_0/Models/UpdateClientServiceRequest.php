<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateClientServiceRequest extends Model
{
    /**
     * @example https://***.png
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @example false
     *
     * @var bool
     */
    public $resetAvatar;

    /**
     * @example false
     *
     * @var bool
     */
    public $resetUserName;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;

    /**
     * @example test
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'avatarUrl' => 'avatarUrl',
        'resetAvatar' => 'resetAvatar',
        'resetUserName' => 'resetUserName',
        'userIds' => 'userIds',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->resetAvatar) {
            $res['resetAvatar'] = $this->resetAvatar;
        }
        if (null !== $this->resetUserName) {
            $res['resetUserName'] = $this->resetUserName;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateClientServiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['resetAvatar'])) {
            $model->resetAvatar = $map['resetAvatar'];
        }
        if (isset($map['resetUserName'])) {
            $model->resetUserName = $map['resetUserName'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
