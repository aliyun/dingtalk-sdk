<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByAuthRequest;

use AlibabaCloud\Tea\Model;

class extension extends Model
{
    /**
     * @var string
     */
    public $bizCode;

    /**
     * @var string
     */
    public $orderNo;

    /**
     * @var string
     */
    public $orderType;
    protected $_name = [
        'bizCode'   => 'bizCode',
        'orderNo'   => 'orderNo',
        'orderType' => 'orderType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->orderType) {
            $res['orderType'] = $this->orderType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extension
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['orderType'])) {
            $model->orderType = $map['orderType'];
        }

        return $model;
    }
}
