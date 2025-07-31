<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreQueryConversationResponseBody extends Model
{
    /**
     * @var string
     */
    public $conversationTitle;

    /**
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'conversationTitle' => 'conversationTitle',
        'openConversationId' => 'openConversationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationTitle) {
            $res['conversationTitle'] = $this->conversationTitle;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreQueryConversationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationTitle'])) {
            $model->conversationTitle = $map['conversationTitle'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
