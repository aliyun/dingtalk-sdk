<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchRecallGroupResponseBody extends Model
{
    /**
     * @description 撤回成功的消息id
     *
     * @var string[]
     */
    public $successResult;

    /**
     * @description 撤回失败的消息id及原因
     *
     * @var string[]
     */
    public $failedResult;
    protected $_name = [
        'successResult' => 'successResult',
        'failedResult'  => 'failedResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->successResult) {
            $res['successResult'] = $this->successResult;
        }
        if (null !== $this->failedResult) {
            $res['failedResult'] = $this->failedResult;
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
        if (isset($map['successResult'])) {
            if (!empty($map['successResult'])) {
                $model->successResult = $map['successResult'];
            }
        }
        if (isset($map['failedResult'])) {
            $model->failedResult = $map['failedResult'];
        }

        return $model;
    }
}
