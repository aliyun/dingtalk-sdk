<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\StaffLabelRecordsQueryRequest\body;

use AlibabaCloud\Tea\Model;

class labels extends Model
{
    /**
     * @example long_termism_score
     *
     * @var string
     */
    public $code;

    /**
     * @example values
     *
     * @var string
     */
    public $typeCode;
    protected $_name = [
        'code' => 'code',
        'typeCode' => 'typeCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->typeCode) {
            $res['typeCode'] = $this->typeCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return labels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['typeCode'])) {
            $model->typeCode = $map['typeCode'];
        }

        return $model;
    }
}
