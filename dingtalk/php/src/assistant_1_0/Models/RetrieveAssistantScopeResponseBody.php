<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class RetrieveAssistantScopeResponseBody extends Model
{
    /**
     * @var string
     */
    public $assistantId;

    /**
     * @var bool
     */
    public $sharing;
    protected $_name = [
        'assistantId' => 'assistantId',
        'sharing'     => 'sharing',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->sharing) {
            $res['sharing'] = $this->sharing;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RetrieveAssistantScopeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['sharing'])) {
            $model->sharing = $map['sharing'];
        }

        return $model;
    }
}
