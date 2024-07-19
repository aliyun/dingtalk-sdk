<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\PersonalSendCardMessageRequest\cardContent;
use AlibabaCloud\Tea\Model;

class PersonalSendCardMessageRequest extends Model
{
    /**
     * @var string[]
     */
    public $atUserIds;

    /**
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
    protected $_name = [
        'atUserIds'          => 'atUserIds',
        'cardContent'        => 'cardContent',
        'openConversationId' => 'openConversationId',
        'receiveUserId'      => 'receiveUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atUserIds) {
            $res['atUserIds'] = $this->atUserIds;
        }
        if (null !== $this->cardContent) {
            $res['cardContent'] = null !== $this->cardContent ? $this->cardContent->toMap() : null;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->receiveUserId) {
            $res['receiveUserId'] = $this->receiveUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PersonalSendCardMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atUserIds'])) {
            if (!empty($map['atUserIds'])) {
                $model->atUserIds = $map['atUserIds'];
            }
        }
        if (isset($map['cardContent'])) {
            $model->cardContent = cardContent::fromMap($map['cardContent']);
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['receiveUserId'])) {
            $model->receiveUserId = $map['receiveUserId'];
        }

        return $model;
    }
}
