<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class ImportMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example {"content":"月会通知<@all> ","at":{"atUserIds":[],"isAtAll":true}}
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $createTime;

    /**
     * @description This parameter is required.
     *
     * @example axcf*-*****-*****-23da*
     *
     * @var string
     */
    public $importUuid;

    /**
     * @var bool
     */
    public $msgReadStatusSetting;

    /**
     * @description This parameter is required.
     *
     * @example text
     *
     * @var string
     */
    public $msgType;

    /**
     * @description This parameter is required.
     *
     * @example cidt*****Xa4K10w==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var string[]
     */
    public $receivers;

    /**
     * @description This parameter is required.
     *
     * @example 013*****21312
     *
     * @var string
     */
    public $senderId;
    protected $_name = [
        'content' => 'content',
        'createTime' => 'createTime',
        'importUuid' => 'importUuid',
        'msgReadStatusSetting' => 'msgReadStatusSetting',
        'msgType' => 'msgType',
        'openConversationId' => 'openConversationId',
        'receivers' => 'receivers',
        'senderId' => 'senderId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->importUuid) {
            $res['importUuid'] = $this->importUuid;
        }
        if (null !== $this->msgReadStatusSetting) {
            $res['msgReadStatusSetting'] = $this->msgReadStatusSetting;
        }
        if (null !== $this->msgType) {
            $res['msgType'] = $this->msgType;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->receivers) {
            $res['receivers'] = $this->receivers;
        }
        if (null !== $this->senderId) {
            $res['senderId'] = $this->senderId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ImportMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['importUuid'])) {
            $model->importUuid = $map['importUuid'];
        }
        if (isset($map['msgReadStatusSetting'])) {
            $model->msgReadStatusSetting = $map['msgReadStatusSetting'];
        }
        if (isset($map['msgType'])) {
            $model->msgType = $map['msgType'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['receivers'])) {
            if (!empty($map['receivers'])) {
                $model->receivers = $map['receivers'];
            }
        }
        if (isset($map['senderId'])) {
            $model->senderId = $map['senderId'];
        }

        return $model;
    }
}
