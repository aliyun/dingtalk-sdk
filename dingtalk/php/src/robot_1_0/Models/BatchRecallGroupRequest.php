<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchRecallGroupRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dingXXXXXXXXXX
     *
     * @var string
     */
    public $chatbotId;

    /**
     * @description This parameter is required.
     *
     * @example cidfCSpXXXXXXXXXXXchatbotId
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $processQueryKeys;
    protected $_name = [
        'chatbotId'          => 'chatbotId',
        'openConversationId' => 'openConversationId',
        'processQueryKeys'   => 'processQueryKeys',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatbotId) {
            $res['chatbotId'] = $this->chatbotId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->processQueryKeys) {
            $res['processQueryKeys'] = $this->processQueryKeys;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchRecallGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatbotId'])) {
            $model->chatbotId = $map['chatbotId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['processQueryKeys'])) {
            if (!empty($map['processQueryKeys'])) {
                $model->processQueryKeys = $map['processQueryKeys'];
            }
        }

        return $model;
    }
}
