<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetDefineDataResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example DA_123456
     *
     * @var string
     */
    public $dataCode;

    /**
     * @example DEF_123456
     *
     * @var string
     */
    public $defineCode;

    /**
     * @example xx路1号门店
     *
     * @var string
     */
    public $name;

    /**
     * @example -1
     *
     * @var string
     */
    public $parentDataCode;

    /**
     * @example valid
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'dataCode'       => 'dataCode',
        'defineCode'     => 'defineCode',
        'name'           => 'name',
        'parentDataCode' => 'parentDataCode',
        'status'         => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataCode) {
            $res['dataCode'] = $this->dataCode;
        }
        if (null !== $this->defineCode) {
            $res['defineCode'] = $this->defineCode;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentDataCode) {
            $res['parentDataCode'] = $this->parentDataCode;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
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
        if (isset($map['dataCode'])) {
            $model->dataCode = $map['dataCode'];
        }
        if (isset($map['defineCode'])) {
            $model->defineCode = $map['defineCode'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentDataCode'])) {
            $model->parentDataCode = $map['parentDataCode'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
