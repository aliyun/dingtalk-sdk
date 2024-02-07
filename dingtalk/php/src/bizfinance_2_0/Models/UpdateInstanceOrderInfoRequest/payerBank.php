<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInstanceOrderInfoRequest;

use AlibabaCloud\Tea\Model;

class payerBank extends Model
{
    /**
     * @example 64112222
     *
     * @var string
     */
    public $cardNo;

    /**
     * @example 招商银行
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'cardNo' => 'cardNo',
        'name'   => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardNo) {
            $res['cardNo'] = $this->cardNo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return payerBank
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardNo'])) {
            $model->cardNo = $map['cardNo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
