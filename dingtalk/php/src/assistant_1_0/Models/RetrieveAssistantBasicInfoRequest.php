<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class RetrieveAssistantBasicInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $assistantId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'assistantId' => 'assistantId',
        'unionId'     => 'unionId',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RetrieveAssistantBasicInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
