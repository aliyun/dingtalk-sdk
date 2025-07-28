<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\LoginForVisitorResponseBody\aimInfo;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\LoginForVisitorResponseBody\aimToken;
use AlibabaCloud\Tea\Model;

class LoginForVisitorResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var aimInfo
     */
    public $aimInfo;

    /**
     * @description This parameter is required.
     *
     * @var aimToken
     */
    public $aimToken;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $appUid;

    /**
     * @description This parameter is required.
     *
     * @example channel_123
     *
     * @var string
     */
    public $channelCode;

    /**
     * @description This parameter is required.
     *
     * @example device_001
     *
     * @var string
     */
    public $deviceId;

    /**
     * @example example.com
     *
     * @var string
     */
    public $safeDomainName;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $userName;

    /**
     * @description This parameter is required.
     *
     * @example @123456
     *
     * @var string
     */
    public $visitorAvatar;

    /**
     * @description This parameter is required.
     *
     * @example https://example.com/acd123.jpg
     *
     * @var string
     */
    public $visitorAvatarUrl;

    /**
     * @description This parameter is required.
     *
     * @example cid_12345
     *
     * @var string
     */
    public $visitorCid;

    /**
     * @description This parameter is required.
     *
     * @example openconversation_12345
     *
     * @var string
     */
    public $visitorOpenConversationId;
    protected $_name = [
        'aimInfo' => 'aimInfo',
        'aimToken' => 'aimToken',
        'appUid' => 'appUid',
        'channelCode' => 'channelCode',
        'deviceId' => 'deviceId',
        'safeDomainName' => 'safeDomainName',
        'userName' => 'userName',
        'visitorAvatar' => 'visitorAvatar',
        'visitorAvatarUrl' => 'visitorAvatarUrl',
        'visitorCid' => 'visitorCid',
        'visitorOpenConversationId' => 'visitorOpenConversationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aimInfo) {
            $res['aimInfo'] = null !== $this->aimInfo ? $this->aimInfo->toMap() : null;
        }
        if (null !== $this->aimToken) {
            $res['aimToken'] = null !== $this->aimToken ? $this->aimToken->toMap() : null;
        }
        if (null !== $this->appUid) {
            $res['appUid'] = $this->appUid;
        }
        if (null !== $this->channelCode) {
            $res['channelCode'] = $this->channelCode;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->safeDomainName) {
            $res['safeDomainName'] = $this->safeDomainName;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->visitorAvatar) {
            $res['visitorAvatar'] = $this->visitorAvatar;
        }
        if (null !== $this->visitorAvatarUrl) {
            $res['visitorAvatarUrl'] = $this->visitorAvatarUrl;
        }
        if (null !== $this->visitorCid) {
            $res['visitorCid'] = $this->visitorCid;
        }
        if (null !== $this->visitorOpenConversationId) {
            $res['visitorOpenConversationId'] = $this->visitorOpenConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LoginForVisitorResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aimInfo'])) {
            $model->aimInfo = aimInfo::fromMap($map['aimInfo']);
        }
        if (isset($map['aimToken'])) {
            $model->aimToken = aimToken::fromMap($map['aimToken']);
        }
        if (isset($map['appUid'])) {
            $model->appUid = $map['appUid'];
        }
        if (isset($map['channelCode'])) {
            $model->channelCode = $map['channelCode'];
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['safeDomainName'])) {
            $model->safeDomainName = $map['safeDomainName'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['visitorAvatar'])) {
            $model->visitorAvatar = $map['visitorAvatar'];
        }
        if (isset($map['visitorAvatarUrl'])) {
            $model->visitorAvatarUrl = $map['visitorAvatarUrl'];
        }
        if (isset($map['visitorCid'])) {
            $model->visitorCid = $map['visitorCid'];
        }
        if (isset($map['visitorOpenConversationId'])) {
            $model->visitorOpenConversationId = $map['visitorOpenConversationId'];
        }

        return $model;
    }
}
