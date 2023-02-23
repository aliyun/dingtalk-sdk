<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateInterconnectionRequest;

use AlibabaCloud\Tea\Model;

class interconnections extends Model
{
    /**
     * @description 钉外账号头像链接。
     *
     * @var string
     */
    public $appUserAvatar;

    /**
     * @description 钉外账号头像类型，取值：
     * 1（http类型）
     * @var int
     */
    public $appUserAvatarMediaType;

    /**
     * @description 钉外账号用户动态，例如：认真工作，快乐生活。
     *
     * @var string
     */
    public $appUserDynamics;

    /**
     * @description 钉外账号在业务系统内的唯一标识。
     *
     * @var string
     */
    public $appUserId;

    /**
     * @description 钉外账号手机号，例如：188****8655。
     *
     * @var string
     */
    public $appUserMobile;

    /**
     * @description 钉外账号名称。
     *
     * @var string
     */
    public $appUserName;

    /**
     * @description 渠道code。
     *
     * @var string
     */
    public $channelCode;

    /**
     * @description 钉内账号userId。
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
