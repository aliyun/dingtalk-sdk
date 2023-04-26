<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateAppOrderRequest\detailList;
use AlibabaCloud\Tea\Model;

class CreateAppOrderRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $actualAmount;

    /**
     * @example 1234
     *
     * @var string
     */
    public $alipayAppId;

    /**
     * @example 1
     *
     * @var int
     */
    public $bizCode;

    /**
     * @var detailList[]
     */
    public $detailList;

    /**
     * @example 1
     *
     * @var int
     */
    public $labelAmount;

    /**
     * @example 10000
     *
     * @var string
     */
    public $merchantId;

    /**
     * @example M00001
     *
     * @var string
     */
    public $merchantOrderNo;

    /**
     * @example 10000
     *
     * @var string
     */
    public $outerUserId;

    /**
     * @example WWrhziOLF/XuRd3IyKwLkLeSFgKnUfeg2yLEVD9Bw+8
     *
     * @var string
     */
    public $signature;

    /**
     * @example 数字图书
     *
     * @var string
     */
    public $subject;

    /**
     * @example 100000
     *
     * @var int
     */
    public $timestamp;
    protected $_name = [
        'actualAmount'    => 'actualAmount',
        'alipayAppId'     => 'alipayAppId',
        'bizCode'         => 'bizCode',
        'detailList'      => 'detailList',
        'labelAmount'     => 'labelAmount',
        'merchantId'      => 'merchantId',
        'merchantOrderNo' => 'merchantOrderNo',
        'outerUserId'     => 'outerUserId',
        'signature'       => 'signature',
        'subject'         => 'subject',
        'timestamp'       => 'timestamp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actualAmount) {
            $res['actualAmount'] = $this->actualAmount;
        }
        if (null !== $this->alipayAppId) {
            $res['alipayAppId'] = $this->alipayAppId;
        }
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->detailList) {
            $res['detailList'] = [];
            if (null !== $this->detailList && \is_array($this->detailList)) {
                $n = 0;
                foreach ($this->detailList as $item) {
                    $res['detailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->labelAmount) {
            $res['labelAmount'] = $this->labelAmount;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->merchantOrderNo) {
            $res['merchantOrderNo'] = $this->merchantOrderNo;
        }
        if (null !== $this->outerUserId) {
            $res['outerUserId'] = $this->outerUserId;
        }
        if (null !== $this->signature) {
            $res['signature'] = $this->signature;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAppOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
        }
        if (isset($map['alipayAppId'])) {
            $model->alipayAppId = $map['alipayAppId'];
        }
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['detailList'])) {
            if (!empty($map['detailList'])) {
                $model->detailList = [];
                $n                 = 0;
                foreach ($map['detailList'] as $item) {
                    $model->detailList[$n++] = null !== $item ? detailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['labelAmount'])) {
            $model->labelAmount = $map['labelAmount'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['merchantOrderNo'])) {
            $model->merchantOrderNo = $map['merchantOrderNo'];
        }
        if (isset($map['outerUserId'])) {
            $model->outerUserId = $map['outerUserId'];
        }
        if (isset($map['signature'])) {
            $model->signature = $map['signature'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }

        return $model;
    }
}
