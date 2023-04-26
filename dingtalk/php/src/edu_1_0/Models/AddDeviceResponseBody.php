<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddDeviceResponseBody extends Model
{
    /**
     * @example 123
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 1002
     *
     * @var int
     */
    public $id;

    /**
     * @example 123
     *
     * @var string
     */
    public $merchantId;

    /**
     * @example 123123
     *
     * @var string
     */
    public $sn;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'corpId'     => 'corpId',
        'id'         => 'id',
        'merchantId' => 'merchantId',
        'sn'         => 'sn',
        'status'     => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddDeviceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
