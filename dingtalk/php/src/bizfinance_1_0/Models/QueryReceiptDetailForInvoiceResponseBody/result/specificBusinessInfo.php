<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceResponseBody\result\specificBusinessInfo\specificBusinessInfoList;
use AlibabaCloud\Tea\Model;

class specificBusinessInfo extends Model
{
    /**
     * @example lease
     *
     * @var string
     */
    public $specialBizCode;

    /**
     * @var specificBusinessInfoList[]
     */
    public $specificBusinessInfoList;
    protected $_name = [
        'specialBizCode' => 'specialBizCode',
        'specificBusinessInfoList' => 'specificBusinessInfoList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->specialBizCode) {
            $res['specialBizCode'] = $this->specialBizCode;
        }
        if (null !== $this->specificBusinessInfoList) {
            $res['specificBusinessInfoList'] = [];
            if (null !== $this->specificBusinessInfoList && \is_array($this->specificBusinessInfoList)) {
                $n = 0;
                foreach ($this->specificBusinessInfoList as $item) {
                    $res['specificBusinessInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return specificBusinessInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['specialBizCode'])) {
            $model->specialBizCode = $map['specialBizCode'];
        }
        if (isset($map['specificBusinessInfoList'])) {
            if (!empty($map['specificBusinessInfoList'])) {
                $model->specificBusinessInfoList = [];
                $n = 0;
                foreach ($map['specificBusinessInfoList'] as $item) {
                    $model->specificBusinessInfoList[$n++] = null !== $item ? specificBusinessInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
