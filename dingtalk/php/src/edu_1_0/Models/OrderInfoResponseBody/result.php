<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\OrderInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\OrderInfoResponseBody\result\itemList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example xxx店铺
     *
     * @var string
     */
    public $address;

    /**
     * @var itemList[]
     */
    public $itemList;

    /**
     * @example 808324521
     *
     * @var string
     */
    public $orderNo;

    /**
     * @example 7245
     *
     * @var string
     */
    public $receiverPhoneSuffix;

    /**
     * @example 商家名称
     *
     * @var string
     */
    public $shopName;

    /**
     * @var int
     */
    public $userId;
    protected $_name = [
        'address'             => 'address',
        'itemList'            => 'itemList',
        'orderNo'             => 'orderNo',
        'receiverPhoneSuffix' => 'receiverPhoneSuffix',
        'shopName'            => 'shopName',
        'userId'              => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->itemList) {
            $res['itemList'] = [];
            if (null !== $this->itemList && \is_array($this->itemList)) {
                $n = 0;
                foreach ($this->itemList as $item) {
                    $res['itemList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->receiverPhoneSuffix) {
            $res['receiverPhoneSuffix'] = $this->receiverPhoneSuffix;
        }
        if (null !== $this->shopName) {
            $res['shopName'] = $this->shopName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['itemList'])) {
            if (!empty($map['itemList'])) {
                $model->itemList = [];
                $n               = 0;
                foreach ($map['itemList'] as $item) {
                    $model->itemList[$n++] = null !== $item ? itemList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['receiverPhoneSuffix'])) {
            $model->receiverPhoneSuffix = $map['receiverPhoneSuffix'];
        }
        if (isset($map['shopName'])) {
            $model->shopName = $map['shopName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
