<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInterconnectionUrlRequest extends Model
{
    /**
     * @var string
     */
    public $appUserAvatar;

    /**
     * @var int
     */
    public $appUserAvatarType;

    /**
     * @var string
     */
    public $appUserId;

    /**
     * @var string
     */
    public $appUserMobileNumber;

    /**
     * @var string
     */
    public $appUserName;

    /**
     * @var int
     */
    public $msgPageType;

    /**
     * @var string
     */
    public $qrCode;

    /**
     * @var string
     */
    public $signature;

    /**
     * @var string
     */
    public $sourceCode;

    /**
     * @var int
     */
    public $sourceType;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'appUserAvatar'       => 'appUserAvatar',
        'appUserAvatarType'   => 'appUserAvatarType',
        'appUserId'           => 'appUserId',
        'appUserMobileNumber' => 'appUserMobileNumber',
        'appUserName'         => 'appUserName',
        'msgPageType'         => 'msgPageType',
        'qrCode'              => 'qrCode',
        'signature'           => 'signature',
        'sourceCode'          => 'sourceCode',
        'sourceType'          => 'sourceType',
        'userId'              => 'userId',
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
        if (null !== $this->appUserAvatarType) {
            $res['appUserAvatarType'] = $this->appUserAvatarType;
        }
        if (null !== $this->appUserId) {
            $res['appUserId'] = $this->appUserId;
        }
        if (null !== $this->appUserMobileNumber) {
            $res['appUserMobileNumber'] = $this->appUserMobileNumber;
        }
        if (null !== $this->appUserName) {
            $res['appUserName'] = $this->appUserName;
        }
        if (null !== $this->msgPageType) {
            $res['msgPageType'] = $this->msgPageType;
        }
        if (null !== $this->qrCode) {
            $res['qrCode'] = $this->qrCode;
        }
        if (null !== $this->signature) {
            $res['signature'] = $this->signature;
        }
        if (null !== $this->sourceCode) {
            $res['sourceCode'] = $this->sourceCode;
        }
        if (null !== $this->sourceType) {
            $res['sourceType'] = $this->sourceType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['appUserAvatar'])) {
            $model->appUserAvatar = $map['appUserAvatar'];
        }
        if (isset($map['appUserAvatarType'])) {
            $model->appUserAvatarType = $map['appUserAvatarType'];
        }
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
        }
        if (isset($map['appUserMobileNumber'])) {
            $model->appUserMobileNumber = $map['appUserMobileNumber'];
        }
        if (isset($map['appUserName'])) {
            $model->appUserName = $map['appUserName'];
        }
        if (isset($map['msgPageType'])) {
            $model->msgPageType = $map['msgPageType'];
        }
        if (isset($map['qrCode'])) {
            $model->qrCode = $map['qrCode'];
        }
        if (isset($map['signature'])) {
            $model->signature = $map['signature'];
        }
        if (isset($map['sourceCode'])) {
            $model->sourceCode = $map['sourceCode'];
        }
        if (isset($map['sourceType'])) {
            $model->sourceType = $map['sourceType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
