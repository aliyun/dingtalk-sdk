<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\CreatePayableReceiptRequest\receipt;

use AlibabaCloud\Tea\Model;

class dangAnDataInfoList extends Model
{
    /**
     * @var string
     */
    public $dataCode;

    /**
     * @var string
     */
    public $defineCode;
    protected $_name = [
        'dataCode' => 'dataCode',
        'defineCode' => 'defineCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataCode) {
            $res['dataCode'] = $this->dataCode;
        }
        if (null !== $this->defineCode) {
            $res['defineCode'] = $this->defineCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dangAnDataInfoList
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

        return $model;
    }
}
