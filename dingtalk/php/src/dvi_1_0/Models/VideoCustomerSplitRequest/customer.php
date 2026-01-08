<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitRequest;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitRequest\customer\customers;
use AlibabaCloud\Tea\Model;

class customer extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var customers[]
     */
    public $customers;
    protected $_name = [
        'customers' => 'customers',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customers) {
            $res['customers'] = [];
            if (null !== $this->customers && \is_array($this->customers)) {
                $n = 0;
                foreach ($this->customers as $item) {
                    $res['customers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return customer
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customers'])) {
            if (!empty($map['customers'])) {
                $model->customers = [];
                $n = 0;
                foreach ($map['customers'] as $item) {
                    $model->customers[$n++] = null !== $item ? customers::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
