<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByAuthRequest\extension;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByAuthRequest\invoices;
use AlibabaCloud\Tea\Model;

class UploadInvoiceByAuthRequest extends Model
{
    /**
     * @var extension
     */
    public $extension;

    /**
     * @var invoices[]
     */
    public $invoices;
    protected $_name = [
        'extension' => 'extension',
        'invoices'  => 'invoices',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadInvoiceByAuthRequest
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

        return $model;
    }
}
