<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainLabelEmpDeleteRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $labelCode;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $workNos;
    protected $_name = [
        'labelCode' => 'labelCode',
        'workNos' => 'workNos',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->labelCode) {
            $res['labelCode'] = $this->labelCode;
        }
        if (null !== $this->workNos) {
            $res['workNos'] = $this->workNos;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainLabelEmpDeleteRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['labelCode'])) {
            $model->labelCode = $map['labelCode'];
        }
        if (isset($map['workNos'])) {
            if (!empty($map['workNos'])) {
                $model->workNos = $map['workNos'];
            }
        }

        return $model;
    }
}
