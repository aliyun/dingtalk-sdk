<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInvoiceUrlRequest;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInvoiceUrlRequest\body\urlList;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $companyCode;

    /**
     * @var string
     */
    public $operator;

    /**
     * @var urlList[]
     */
    public $urlList;
    protected $_name = [
        'companyCode' => 'companyCode',
        'operator'    => 'operator',
        'urlList'     => 'urlList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->urlList) {
            $res['urlList'] = [];
            if (null !== $this->urlList && \is_array($this->urlList)) {
                $n = 0;
                foreach ($this->urlList as $item) {
                    $res['urlList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['urlList'])) {
            if (!empty($map['urlList'])) {
                $model->urlList = [];
                $n              = 0;
                foreach ($map['urlList'] as $item) {
                    $model->urlList[$n++] = null !== $item ? urlList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
