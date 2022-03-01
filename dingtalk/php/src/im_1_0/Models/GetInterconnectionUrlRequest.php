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
     * @description qrCode
     *
     * @var string
     */
    public $qrCode;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description msgPageType
     *
     * @var int
     */
    public $msgPageType;

    /**
     * @description sourceType
     *
     * @var int
     */
    public $sourceType;

    /**
     * @description sourceCode
     *
     * @var string
     */
    public $sourceCode;

    /**
     * @description signature
     *
     * @var string
     */
    public $signature;
    protected $_name = [
        'appUserId'           => 'appUserId',
        'appUserName'         => 'appUserName',
        'appUserAvatar'       => 'appUserAvatar',
        'appUserAvatarType'   => 'appUserAvatarType',
        'appUserMobileNumber' => 'appUserMobileNumber',
        'qrCode'              => 'qrCode',
        'userId'              => 'userId',
        'msgPageType'         => 'msgPageType',
        'sourceType'          => 'sourceType',
        'sourceCode'          => 'sourceCode',
        'signature'           => 'signature',
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
        if (null !== $this->qrCode) {
            $res['qrCode'] = $this->qrCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->msgPageType) {
            $res['msgPageType'] = $this->msgPageType;
        }
        if (null !== $this->sourceType) {
            $res['sourceType'] = $this->sourceType;
        }
        if (null !== $this->sourceCode) {
            $res['sourceCode'] = $this->sourceCode;
        }
        if (null !== $this->signature) {
            $res['signature'] = $this->signature;
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
        if (isset($map['qrCode'])) {
            $model->qrCode = $map['qrCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['msgPageType'])) {
            $model->msgPageType = $map['msgPageType'];
        }
        if (isset($map['sourceType'])) {
            $model->sourceType = $map['sourceType'];
        }
        if (isset($map['sourceCode'])) {
            $model->sourceCode = $map['sourceCode'];
        }
        if (isset($map['signature'])) {
            $model->signature = $map['signature'];
        }

        return $model;
    }
}
