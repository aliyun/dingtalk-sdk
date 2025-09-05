<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripInvoiceRequest;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripInvoiceRequest\invoiceDetailList\travelItineraryInfoList;
use AlibabaCloud\Tea\Model;

class invoiceDetailList extends Model
{
    /**
     * @var string
     */
    public $failCode;

    /**
     * @var string
     */
    public $failMessage;

    /**
     * @var bool
     */
    public $invoiceResult;

    /**
     * @var string
     */
    public $ofdInvoiceUrl;

    /**
     * @var string
     */
    public $pdfInvoiceUrl;

    /**
     * @var travelItineraryInfoList[]
     */
    public $travelItineraryInfoList;

    /**
     * @var string
     */
    public $xmlInvoiceUrl;
    protected $_name = [
        'failCode' => 'failCode',
        'failMessage' => 'failMessage',
        'invoiceResult' => 'invoiceResult',
        'ofdInvoiceUrl' => 'ofdInvoiceUrl',
        'pdfInvoiceUrl' => 'pdfInvoiceUrl',
        'travelItineraryInfoList' => 'travelItineraryInfoList',
        'xmlInvoiceUrl' => 'xmlInvoiceUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failCode) {
            $res['failCode'] = $this->failCode;
        }
        if (null !== $this->failMessage) {
            $res['failMessage'] = $this->failMessage;
        }
        if (null !== $this->invoiceResult) {
            $res['invoiceResult'] = $this->invoiceResult;
        }
        if (null !== $this->ofdInvoiceUrl) {
            $res['ofdInvoiceUrl'] = $this->ofdInvoiceUrl;
        }
        if (null !== $this->pdfInvoiceUrl) {
            $res['pdfInvoiceUrl'] = $this->pdfInvoiceUrl;
        }
        if (null !== $this->travelItineraryInfoList) {
            $res['travelItineraryInfoList'] = [];
            if (null !== $this->travelItineraryInfoList && \is_array($this->travelItineraryInfoList)) {
                $n = 0;
                foreach ($this->travelItineraryInfoList as $item) {
                    $res['travelItineraryInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->xmlInvoiceUrl) {
            $res['xmlInvoiceUrl'] = $this->xmlInvoiceUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return invoiceDetailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failCode'])) {
            $model->failCode = $map['failCode'];
        }
        if (isset($map['failMessage'])) {
            $model->failMessage = $map['failMessage'];
        }
        if (isset($map['invoiceResult'])) {
            $model->invoiceResult = $map['invoiceResult'];
        }
        if (isset($map['ofdInvoiceUrl'])) {
            $model->ofdInvoiceUrl = $map['ofdInvoiceUrl'];
        }
        if (isset($map['pdfInvoiceUrl'])) {
            $model->pdfInvoiceUrl = $map['pdfInvoiceUrl'];
        }
        if (isset($map['travelItineraryInfoList'])) {
            if (!empty($map['travelItineraryInfoList'])) {
                $model->travelItineraryInfoList = [];
                $n = 0;
                foreach ($map['travelItineraryInfoList'] as $item) {
                    $model->travelItineraryInfoList[$n++] = null !== $item ? travelItineraryInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['xmlInvoiceUrl'])) {
            $model->xmlInvoiceUrl = $map['xmlInvoiceUrl'];
        }

        return $model;
    }
}
