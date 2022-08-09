<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountPeriodResponseBody\errorResult;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountPeriodResponseBody\successResult;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceAccountPeriodResponseBody extends Model
{
    /**
     * @description 错误信息
     *
     * @var errorResult[]
     */
    public $errorResult;

    /**
     * @description 成功信息
     *
     * @var successResult[]
     */
    public $successResult;
    protected $_name = [
        'errorResult'   => 'errorResult',
        'successResult' => 'successResult',
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
        if (null !== $this->successResult) {
            $res['successResult'] = [];
            if (null !== $this->successResult && \is_array($this->successResult)) {
                $n = 0;
                foreach ($this->successResult as $item) {
                    $res['successResult'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInvoiceAccountPeriodResponseBody
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
        if (isset($map['successResult'])) {
            if (!empty($map['successResult'])) {
                $model->successResult = [];
                $n                    = 0;
                foreach ($map['successResult'] as $item) {
                    $model->successResult[$n++] = null !== $item ? successResult::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
