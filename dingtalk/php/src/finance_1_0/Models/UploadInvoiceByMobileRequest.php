<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByMobileRequest\invoices;
use AlibabaCloud\Tea\Model;

class UploadInvoiceByMobileRequest extends Model
{
    /**
     * @description 上传发票列表
     *
     * @var invoices[]
     */
    public $invoices;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $mobile;

    /**
     * @description 手机号国家码
     *
     * @var string
     */
    public $mobileStateCode;
    protected $_name = [
        'invoices'        => 'invoices',
        'mobile'          => 'mobile',
        'mobileStateCode' => 'mobileStateCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->invoices) {
            $res['invoices'] = [];
            if (null !== $this->invoices && \is_array($this->invoices)) {
                $n = 0;
                foreach ($this->invoices as $item) {
                    $res['invoices'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->mobileStateCode) {
            $res['mobileStateCode'] = $this->mobileStateCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadInvoiceByMobileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['invoices'])) {
            if (!empty($map['invoices'])) {
                $model->invoices = [];
                $n               = 0;
                foreach ($map['invoices'] as $item) {
                    $model->invoices[$n++] = null !== $item ? invoices::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['mobileStateCode'])) {
            $model->mobileStateCode = $map['mobileStateCode'];
        }

        return $model;
    }
}
