<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListInstanceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $prototypeAssistantId;
    protected $_name = [
        'prototypeAssistantId' => 'prototypeAssistantId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->prototypeAssistantId) {
            $res['prototypeAssistantId'] = $this->prototypeAssistantId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['prototypeAssistantId'])) {
            $model->prototypeAssistantId = $map['prototypeAssistantId'];
        }

        return $model;
    }
}
