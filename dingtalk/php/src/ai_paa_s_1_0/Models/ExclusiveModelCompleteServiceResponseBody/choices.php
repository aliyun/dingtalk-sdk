<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\ExclusiveModelCompleteServiceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\ExclusiveModelCompleteServiceResponseBody\choices\message;
use AlibabaCloud\Tea\Model;

class choices extends Model
{
    /**
     * @var string
     */
    public $finishReason;

    /**
     * @var message
     */
    public $message;
    protected $_name = [
        'finishReason' => 'finishReason',
        'message'      => 'message',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->finishReason) {
            $res['finishReason'] = $this->finishReason;
        }
        if (null !== $this->message) {
            $res['message'] = null !== $this->message ? $this->message->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return choices
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['finishReason'])) {
            $model->finishReason = $map['finishReason'];
        }
        if (isset($map['message'])) {
            $model->message = message::fromMap($map['message']);
        }

        return $model;
    }
}
