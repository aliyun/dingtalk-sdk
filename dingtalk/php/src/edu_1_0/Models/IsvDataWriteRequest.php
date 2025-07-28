<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class IsvDataWriteRequest extends Model
{
    /**
     * @example tb_test01
     *
     * @var string
     */
    public $objectCode;

    /**
     * @var undefined[][]
     */
    public $rowValueList;
    protected $_name = [
        'objectCode' => 'objectCode',
        'rowValueList' => 'rowValueList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectCode) {
            $res['objectCode'] = $this->objectCode;
        }
        if (null !== $this->rowValueList) {
            $res['rowValueList'] = $this->rowValueList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IsvDataWriteRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectCode'])) {
            $model->objectCode = $map['objectCode'];
        }
        if (isset($map['rowValueList'])) {
            if (!empty($map['rowValueList'])) {
                $model->rowValueList = $map['rowValueList'];
            }
        }

        return $model;
    }
}
