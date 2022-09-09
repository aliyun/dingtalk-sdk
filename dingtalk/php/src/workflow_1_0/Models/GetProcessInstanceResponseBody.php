<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result;
use AlibabaCloud\Tea\Model;

class GetProcessInstanceResponseBody extends Model
{
    /**
     * @description 返回结果。
     *
     * @var result
     */
    public $result;

    /**
     * @description 调用是否成功。
     *
     * @var string
     */
    public $success;
    protected $_name = [
        'result'  => 'result',
        'success' => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->result) {
            $res['result'] = null !== $this->result ? $this->result->toMap() : null;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProcessInstanceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['result'])) {
            $model->result = result::fromMap($map['result']);
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
