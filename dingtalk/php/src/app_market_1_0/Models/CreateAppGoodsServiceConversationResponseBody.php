<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAppGoodsServiceConversationResponseBody extends Model
{
    /**
     * @description 群名称
     *
     * @var string
     */
    public $conversationName;

    /**
     * @description 是否新群
     *
     * @var bool
     */
    public $newConversation;
    protected $_name = [
        'conversationName' => 'conversationName',
        'newConversation'  => 'newConversation',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationName) {
            $res['conversationName'] = $this->conversationName;
        }
        if (null !== $this->newConversation) {
            $res['newConversation'] = $this->newConversation;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAppGoodsServiceConversationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationName'])) {
            $model->conversationName = $map['conversationName'];
        }
        if (isset($map['newConversation'])) {
            $model->newConversation = $map['newConversation'];
        }

        return $model;
    }
}
