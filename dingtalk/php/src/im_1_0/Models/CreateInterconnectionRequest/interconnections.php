<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateInterconnectionRequest;

use AlibabaCloud\Tea\Model;

class interconnections extends Model
{
    /**
     * @example http://***.png
     *
     * @var string
     */
    public $appUserAvatar;

    /**
     * @example 1
     *
     * @var int
     */
    public $appUserAvatarMediaType;

    /**
     * @example 认真工作,快乐生活
     *
     * @var string
     */
    public $appUserDynamics;

    /**
     * @description This parameter is required.
     *
     * @example 1107****2120
     *
     * @var string
     */
    public $appUserId;

    /**
     * @description This parameter is required.
     *
     * @example 188****8655
     *
     * @var string
     */
    public $appUserMobile;

    /**
     * @description This parameter is required.
     *
     * @example Foo
     *
     * @var string
     */
    public $appUserName;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var string
     */
    public $channelCode;

    /**
     * @example 1745****8777
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appUserAvatar'          => 'appUserAvatar',
        'appUserAvatarMediaType' => 'appUserAvatarMediaType',
        'appUserDynamics'        => 'appUserDynamics',
        'appUserId'              => 'appUserId',
        'appUserMobile'          => 'appUserMobile',
        'appUserName'            => 'appUserName',
        'channelCode'            => 'channelCode',
        'userId'                 => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserAvatar) {
            $res['appUserAvatar'] = $this->appUserAvatar;
        }
        if (null !== $this->appUserAvatarMediaType) {
            $res['appUserAvatarMediaType'] = $this->appUserAvatarMediaType;
        }
        if (null !== $this->appUserDynamics) {
            $res['appUserDynamics'] = $this->appUserDynamics;
        }
        if (null !== $this->appUserId) {
            $res['appUserId'] = $this->appUserId;
        }
        if (null !== $this->appUserMobile) {
            $res['appUserMobile'] = $this->appUserMobile;
        }
        if (null !== $this->appUserName) {
            $res['appUserName'] = $this->appUserName;
        }
        if (null !== $this->channelCode) {
            $res['channelCode'] = $this->channelCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return interconnections
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserAvatar'])) {
            $model->appUserAvatar = $map['appUserAvatar'];
        }
        if (isset($map['appUserAvatarMediaType'])) {
            $model->appUserAvatarMediaType = $map['appUserAvatarMediaType'];
        }
        if (isset($map['appUserDynamics'])) {
            $model->appUserDynamics = $map['appUserDynamics'];
        }
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
        }
        if (isset($map['appUserMobile'])) {
            $model->appUserMobile = $map['appUserMobile'];
        }
        if (isset($map['appUserName'])) {
            $model->appUserName = $map['appUserName'];
        }
        if (isset($map['channelCode'])) {
            $model->channelCode = $map['channelCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
