<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchRecallPrivateChatResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 5fe11095f46315d8d30d3f8XXXXXX:SYSTEM_ERROR
     *
     * @var string[]
     */
    public $failedResult;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $successResult;
    protected $_name = [
        'failedResult'  => 'failedResult',
        'successResult' => 'successResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->failedResult) {
            $res['failedResult'] = $this->failedResult;
        }
        if (null !== $this->successResult) {
            $res['successResult'] = $this->successResult;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchRecallPrivateChatResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failedResult'])) {
            $model->failedResult = $map['failedResult'];
        }
        if (isset($map['successResult'])) {
            if (!empty($map['successResult'])) {
                $model->successResult = $map['successResult'];
            }
        }

        return $model;
    }
}
