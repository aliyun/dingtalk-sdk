<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncTripInvoiceShrinkRequest extends Model
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
     * @var string
     */
    public $invoiceDetailListShrink;
    protected $_name = [
        'channelOrderNo' => 'channelOrderNo',
        'channelType' => 'channelType',
        'customerCorpId' => 'customerCorpId',
        'dingUserId' => 'dingUserId',
        'invoiceDetailListShrink' => 'invoiceDetailList',
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
        if (null !== $this->invoiceDetailListShrink) {
            $res['invoiceDetailList'] = $this->invoiceDetailListShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncTripInvoiceShrinkRequest
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
            $model->invoiceDetailListShrink = $map['invoiceDetailList'];
        }

        return $model;
    }
}
