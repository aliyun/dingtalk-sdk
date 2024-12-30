<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInvoiceUrlRequest\body;

use AlibabaCloud\Tea\Model;

class urlList extends Model
{
    /**
     * @var string
     */
    public $invoiceCode;

    /**
     * @var string
     */
    public $invoiceNo;

    /**
     * @var string
     */
    public $ofdUrl;

    /**
     * @var string
     */
    public $pdfUrl;

    /**
     * @var string
     */
    public $xmlUrl;
    protected $_name = [
        'invoiceCode' => 'invoiceCode',
        'invoiceNo'   => 'invoiceNo',
        'ofdUrl'      => 'ofdUrl',
        'pdfUrl'      => 'pdfUrl',
        'xmlUrl'      => 'xmlUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }
        if (null !== $this->ofdUrl) {
            $res['ofdUrl'] = $this->ofdUrl;
        }
        if (null !== $this->pdfUrl) {
            $res['pdfUrl'] = $this->pdfUrl;
        }
        if (null !== $this->xmlUrl) {
            $res['xmlUrl'] = $this->xmlUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return urlList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }
        if (isset($map['ofdUrl'])) {
            $model->ofdUrl = $map['ofdUrl'];
        }
        if (isset($map['pdfUrl'])) {
            $model->pdfUrl = $map['pdfUrl'];
        }
        if (isset($map['xmlUrl'])) {
            $model->xmlUrl = $map['xmlUrl'];
        }

        return $model;
    }
}
