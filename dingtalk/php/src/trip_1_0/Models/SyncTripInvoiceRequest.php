<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripInvoiceRequest\invoiceDetailList;
use AlibabaCloud\Tea\Model;

class SyncTripInvoiceRequest extends Model
{
    /**
     * @var string
     */
    public $channelOrderNo;

    /**
     * @var string
     */
    public $channelType;

    /**
     * @var string
     */
    public $customerCorpId;

    /**
     * @var string
     */
    public $dingUserId;

    /**
     * @var invoiceDetailList[]
     */
    public $invoiceDetailList;
    protected $_name = [
        'channelOrderNo' => 'channelOrderNo',
        'channelType' => 'channelType',
        'customerCorpId' => 'customerCorpId',
        'dingUserId' => 'dingUserId',
        'invoiceDetailList' => 'invoiceDetailList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelOrderNo) {
            $res['channelOrderNo'] = $this->channelOrderNo;
        }
        if (null !== $this->channelType) {
            $res['channelType'] = $this->channelType;
        }
        if (null !== $this->customerCorpId) {
            $res['customerCorpId'] = $this->customerCorpId;
        }
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->invoiceDetailList) {
            $res['invoiceDetailList'] = [];
            if (null !== $this->invoiceDetailList && \is_array($this->invoiceDetailList)) {
                $n = 0;
                foreach ($this->invoiceDetailList as $item) {
                    $res['invoiceDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncTripInvoiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelOrderNo'])) {
            $model->channelOrderNo = $map['channelOrderNo'];
        }
        if (isset($map['channelType'])) {
            $model->channelType = $map['channelType'];
        }
        if (isset($map['customerCorpId'])) {
            $model->customerCorpId = $map['customerCorpId'];
        }
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['invoiceDetailList'])) {
            if (!empty($map['invoiceDetailList'])) {
                $model->invoiceDetailList = [];
                $n = 0;
                foreach ($map['invoiceDetailList'] as $item) {
                    $model->invoiceDetailList[$n++] = null !== $item ? invoiceDetailList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
