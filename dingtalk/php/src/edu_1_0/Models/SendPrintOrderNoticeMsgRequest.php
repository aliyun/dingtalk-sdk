<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendPrintOrderNoticeMsgRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $createOrderTime;

    /**
     * @var string
     */
    public $deliveryCompanyName;

    /**
     * @var string
     */
    public $deliveryNumber;

    /**
     * @var string
     */
    public $deliveryTime;

    /**
     * @var string
     */
    public $paymentTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $price;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sceneCode;
    protected $_name = [
        'createOrderTime'     => 'createOrderTime',
        'deliveryCompanyName' => 'deliveryCompanyName',
        'deliveryNumber'      => 'deliveryNumber',
        'deliveryTime'        => 'deliveryTime',
        'paymentTime'         => 'paymentTime',
        'price'               => 'price',
        'sceneCode'           => 'sceneCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createOrderTime) {
            $res['createOrderTime'] = $this->createOrderTime;
        }
        if (null !== $this->deliveryCompanyName) {
            $res['deliveryCompanyName'] = $this->deliveryCompanyName;
        }
        if (null !== $this->deliveryNumber) {
            $res['deliveryNumber'] = $this->deliveryNumber;
        }
        if (null !== $this->deliveryTime) {
            $res['deliveryTime'] = $this->deliveryTime;
        }
        if (null !== $this->paymentTime) {
            $res['paymentTime'] = $this->paymentTime;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->sceneCode) {
            $res['sceneCode'] = $this->sceneCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendPrintOrderNoticeMsgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createOrderTime'])) {
            $model->createOrderTime = $map['createOrderTime'];
        }
        if (isset($map['deliveryCompanyName'])) {
            $model->deliveryCompanyName = $map['deliveryCompanyName'];
        }
        if (isset($map['deliveryNumber'])) {
            $model->deliveryNumber = $map['deliveryNumber'];
        }
        if (isset($map['deliveryTime'])) {
            $model->deliveryTime = $map['deliveryTime'];
        }
        if (isset($map['paymentTime'])) {
            $model->paymentTime = $map['paymentTime'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['sceneCode'])) {
            $model->sceneCode = $map['sceneCode'];
        }

        return $model;
    }
}
