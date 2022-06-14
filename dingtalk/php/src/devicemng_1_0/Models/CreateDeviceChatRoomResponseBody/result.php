<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDeviceChatRoomResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $chatId;

    /**
     * @var string
     */
    public $encodedCid;

    /**
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'chatId'             => 'chatId',
        'encodedCid'         => 'encodedCid',
        'openConversationId' => 'openConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatId) {
            $res['chatId'] = $this->chatId;
        }
        if (null !== $this->encodedCid) {
            $res['encodedCid'] = $this->encodedCid;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatId'])) {
            $model->chatId = $map['chatId'];
        }
        if (isset($map['encodedCid'])) {
            $model->encodedCid = $map['encodedCid'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
