<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchRecallGroupResponseBody extends Model
{
    /**
     * @description 撤回失败的消息id及原因
     *
     * @var string[]
     */
    public $failedResult;

    /**
     * @description 撤回成功的消息id
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
     * @return BatchRecallGroupResponseBody
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
