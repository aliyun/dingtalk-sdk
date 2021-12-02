<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInterconnectionUrlRequest extends Model
{
    /**
     * @description appUserId
     *
     * @var string
     */
    public $appUserId;

    /**
     * @description appUserName
     *
     * @var string
     */
    public $appUserName;

    /**
     * @description appUserAvatar
     *
     * @var string
     */
    public $appUserAvatar;

    /**
     * @description appUserAvatarType
     *
     * @var int
     */
    public $appUserAvatarType;

    /**
     * @description appUserMobileNumber
     *
     * @var string
     */
    public $appUserMobileNumber;

    /**
     * @description dingCorpId
     *
     * @var string
     */
    public $dingCorpId;

    /**
     * @description dingUserId
     *
     * @var string
     */
    public $dingUserId;

    /**
     * @description msgPageSettingId
     *
     * @var int
     */
    public $msgPageSettingId;
    protected $_name = [
        'appUserId'           => 'appUserId',
        'appUserName'         => 'appUserName',
        'appUserAvatar'       => 'appUserAvatar',
        'appUserAvatarType'   => 'appUserAvatarType',
        'appUserMobileNumber' => 'appUserMobileNumber',
        'dingCorpId'          => 'dingCorpId',
        'dingUserId'          => 'dingUserId',
        'msgPageSettingId'    => 'msgPageSettingId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserId) {
            $res['appUserId'] = $this->appUserId;
        }
        if (null !== $this->appUserName) {
            $res['appUserName'] = $this->appUserName;
        }
        if (null !== $this->appUserAvatar) {
            $res['appUserAvatar'] = $this->appUserAvatar;
        }
        if (null !== $this->appUserAvatarType) {
            $res['appUserAvatarType'] = $this->appUserAvatarType;
        }
        if (null !== $this->appUserMobileNumber) {
            $res['appUserMobileNumber'] = $this->appUserMobileNumber;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->msgPageSettingId) {
            $res['msgPageSettingId'] = $this->msgPageSettingId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInterconnectionUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
        }
        if (isset($map['appUserName'])) {
            $model->appUserName = $map['appUserName'];
        }
        if (isset($map['appUserAvatar'])) {
            $model->appUserAvatar = $map['appUserAvatar'];
        }
        if (isset($map['appUserAvatarType'])) {
            $model->appUserAvatarType = $map['appUserAvatarType'];
        }
        if (isset($map['appUserMobileNumber'])) {
            $model->appUserMobileNumber = $map['appUserMobileNumber'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['msgPageSettingId'])) {
            $model->msgPageSettingId = $map['msgPageSettingId'];
        }

        return $model;
    }
}
