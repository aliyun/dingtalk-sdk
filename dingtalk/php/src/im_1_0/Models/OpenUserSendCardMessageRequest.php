<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenUserSendCardMessageRequest\cardContent;
use AlibabaCloud\Tea\Model;

class OpenUserSendCardMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var cardContent
     */
    public $cardContent;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $receiveUserId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'cardContent'        => 'cardContent',
        'openConversationId' => 'openConversationId',
        'receiveUserId'      => 'receiveUserId',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardContent) {
            $res['cardContent'] = null !== $this->cardContent ? $this->cardContent->toMap() : null;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->receiveUserId) {
            $res['receiveUserId'] = $this->receiveUserId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenUserSendCardMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardContent'])) {
            $model->cardContent = cardContent::fromMap($map['cardContent']);
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['receiveUserId'])) {
            $model->receiveUserId = $map['receiveUserId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
