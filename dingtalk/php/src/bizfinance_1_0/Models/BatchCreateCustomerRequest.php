<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchCreateCustomerRequest\createCustomerRequestList;
use AlibabaCloud\Tea\Model;

class BatchCreateCustomerRequest extends Model
{
    /**
     * @var createCustomerRequestList[]
     */
    public $createCustomerRequestList;

    /**
     * @description 创建人userId
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'createCustomerRequestList' => 'createCustomerRequestList',
        'operator'                  => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createCustomerRequestList) {
            $res['createCustomerRequestList'] = [];
            if (null !== $this->createCustomerRequestList && \is_array($this->createCustomerRequestList)) {
                $n = 0;
                foreach ($this->createCustomerRequestList as $item) {
                    $res['createCustomerRequestList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchCreateCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createCustomerRequestList'])) {
            if (!empty($map['createCustomerRequestList'])) {
                $model->createCustomerRequestList = [];
                $n                                = 0;
                foreach ($map['createCustomerRequestList'] as $item) {
                    $model->createCustomerRequestList[$n++] = null !== $item ? createCustomerRequestList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
