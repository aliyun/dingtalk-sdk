<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class RecallPersonalMessageRequest extends Model
{
    /**
     * @example cidxxxx3451=
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example msgxxx112
     *
     * @var string
     */
    public $openMessageId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'openMessageId' => 'openMessageId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openMessageId) {
            $res['openMessageId'] = $this->openMessageId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RecallPersonalMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openMessageId'])) {
            $model->openMessageId = $map['openMessageId'];
        }

        return $model;
    }
}
