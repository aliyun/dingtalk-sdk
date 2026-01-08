<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitRequest\customer;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitRequest\customer\customers\appearance;
use AlibabaCloud\Tea\Model;

class customers extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var appearance
     */
    public $appearance;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $customerId;
    protected $_name = [
        'appearance' => 'appearance',
        'customerId' => 'customerId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appearance) {
            $res['appearance'] = null !== $this->appearance ? $this->appearance->toMap() : null;
        }
        if (null !== $this->customerId) {
            $res['customerId'] = $this->customerId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return customers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appearance'])) {
            $model->appearance = appearance::fromMap($map['appearance']);
        }
        if (isset($map['customerId'])) {
            $model->customerId = $map['customerId'];
        }

        return $model;
    }
}
