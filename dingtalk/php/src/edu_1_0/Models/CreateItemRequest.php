<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateItemRequest extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var int
     */
    public $effectType;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $merchantId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $optUser;

    /**
     * @var int
     */
    public $periodType;

    /**
     * @var int
     */
    public $price;

    /**
     * @var int
     */
    public $scene;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @description 状态
     *
     * @var int
     */
    public $status;

    /**
     * @var int
     */
    public $type;
    protected $_name = [
        'description' => 'description',
        'effectType'  => 'effectType',
        'endTime'     => 'endTime',
        'merchantId'  => 'merchantId',
        'name'        => 'name',
        'optUser'     => 'optUser',
        'periodType'  => 'periodType',
        'price'       => 'price',
        'scene'       => 'scene',
        'startTime'   => 'startTime',
        'status'      => 'status',
        'type'        => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->effectType) {
            $res['effectType'] = $this->effectType;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->optUser) {
            $res['optUser'] = $this->optUser;
        }
        if (null !== $this->periodType) {
            $res['periodType'] = $this->periodType;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateItemRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['effectType'])) {
            $model->effectType = $map['effectType'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['optUser'])) {
            $model->optUser = $map['optUser'];
        }
        if (isset($map['periodType'])) {
            $model->periodType = $map['periodType'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
