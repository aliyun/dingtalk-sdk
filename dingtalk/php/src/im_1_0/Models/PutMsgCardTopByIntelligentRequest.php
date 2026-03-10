<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class PutMsgCardTopByIntelligentRequest extends Model
{
    /**
     * @example cidt*****Xa4K10w==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $openTaskId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'openTaskId' => 'openTaskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openTaskId) {
            $res['openTaskId'] = $this->openTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PutMsgCardTopByIntelligentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openTaskId'])) {
            $model->openTaskId = $map['openTaskId'];
        }

        return $model;
    }
}
