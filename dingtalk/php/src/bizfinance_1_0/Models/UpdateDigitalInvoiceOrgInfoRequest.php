<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateDigitalInvoiceOrgInfoRequest extends Model
{
    /**
     * @description 支持的全电票种
     *
     * @var string[]
     */
    public $digitalInvoiceType;

    /**
     * @description 是否为全电企业
     *
     * @var bool
     */
    public $isDigitalOrg;

    /**
     * @description 报税地点
     *
     * @var string
     */
    public $location;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'digitalInvoiceType' => 'digitalInvoiceType',
        'isDigitalOrg'       => 'isDigitalOrg',
        'location'           => 'location',
        'operator'           => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->digitalInvoiceType) {
            $res['digitalInvoiceType'] = $this->digitalInvoiceType;
        }
        if (null !== $this->isDigitalOrg) {
            $res['isDigitalOrg'] = $this->isDigitalOrg;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateDigitalInvoiceOrgInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['digitalInvoiceType'])) {
            if (!empty($map['digitalInvoiceType'])) {
                $model->digitalInvoiceType = $map['digitalInvoiceType'];
            }
        }
        if (isset($map['isDigitalOrg'])) {
            $model->isDigitalOrg = $map['isDigitalOrg'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
