<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchCreateCustomerResponseBody\errorResult;
use AlibabaCloud\Tea\Model;

class BatchCreateCustomerResponseBody extends Model
{
    /**
     * @var errorResult[]
     */
    public $errorResult;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'errorResult' => 'errorResult',
        'success'     => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorResult) {
            $res['errorResult'] = [];
            if (null !== $this->errorResult && \is_array($this->errorResult)) {
                $n = 0;
                foreach ($this->errorResult as $item) {
                    $res['errorResult'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchCreateCustomerResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorResult'])) {
            if (!empty($map['errorResult'])) {
                $model->errorResult = [];
                $n                  = 0;
                foreach ($map['errorResult'] as $item) {
                    $model->errorResult[$n++] = null !== $item ? errorResult::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
