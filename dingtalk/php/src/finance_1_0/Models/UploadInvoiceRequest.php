<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceRequest\extension;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceRequest\invoices;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceRequest\userIdentity;
use AlibabaCloud\Tea\Model;

class UploadInvoiceRequest extends Model
{
    /**
     * @var extension
     */
    public $extension;

    /**
     * @description 上传发票列表
     *
     * @var invoices[]
     */
    public $invoices;

    /**
     * @var userIdentity
     */
    public $userIdentity;
    protected $_name = [
        'extension'    => 'extension',
        'invoices'     => 'invoices',
        'userIdentity' => 'userIdentity',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extension) {
            $res['extension'] = null !== $this->extension ? $this->extension->toMap() : null;
        }
        if (null !== $this->invoices) {
            $res['invoices'] = [];
            if (null !== $this->invoices && \is_array($this->invoices)) {
                $n = 0;
                foreach ($this->invoices as $item) {
                    $res['invoices'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userIdentity) {
            $res['userIdentity'] = null !== $this->userIdentity ? $this->userIdentity->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadInvoiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extension'])) {
            $model->extension = extension::fromMap($map['extension']);
        }
        if (isset($map['invoices'])) {
            if (!empty($map['invoices'])) {
                $model->invoices = [];
                $n               = 0;
                foreach ($map['invoices'] as $item) {
                    $model->invoices[$n++] = null !== $item ? invoices::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userIdentity'])) {
            $model->userIdentity = userIdentity::fromMap($map['userIdentity']);
        }

        return $model;
    }
}
