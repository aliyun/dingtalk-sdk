<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetFormTemplateInfoResponseBody\receiptFormTemplateInfoList;
use AlibabaCloud\Tea\Model;

class GetFormTemplateInfoResponseBody extends Model
{
    /**
     * @var receiptFormTemplateInfoList[]
     */
    public $receiptFormTemplateInfoList;
    protected $_name = [
        'receiptFormTemplateInfoList' => 'receiptFormTemplateInfoList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->receiptFormTemplateInfoList) {
            $res['receiptFormTemplateInfoList'] = [];
            if (null !== $this->receiptFormTemplateInfoList && \is_array($this->receiptFormTemplateInfoList)) {
                $n = 0;
                foreach ($this->receiptFormTemplateInfoList as $item) {
                    $res['receiptFormTemplateInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFormTemplateInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['receiptFormTemplateInfoList'])) {
            if (!empty($map['receiptFormTemplateInfoList'])) {
                $model->receiptFormTemplateInfoList = [];
                $n                                  = 0;
                foreach ($map['receiptFormTemplateInfoList'] as $item) {
                    $model->receiptFormTemplateInfoList[$n++] = null !== $item ? receiptFormTemplateInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
