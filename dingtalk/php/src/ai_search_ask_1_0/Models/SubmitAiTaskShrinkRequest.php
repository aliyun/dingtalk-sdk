<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models;

use AlibabaCloud\Tea\Model;

class SubmitAiTaskShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $messagesShrink;
    protected $_name = [
        'messagesShrink' => 'messages',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->messagesShrink) {
            $res['messages'] = $this->messagesShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitAiTaskShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messages'])) {
            $model->messagesShrink = $map['messages'];
        }

        return $model;
    }
}
