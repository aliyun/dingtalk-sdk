<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetBranchAuthDataResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example teacherCnt
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @example 老师数量
     *
     * @var string
     */
    public $fieldName;

    /**
     * @example 120
     *
     * @var string
     */
    public $fieldValue;
    protected $_name = [
        'fieldCode'  => 'fieldCode',
        'fieldName'  => 'fieldName',
        'fieldValue' => 'fieldValue',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldValue) {
            $res['fieldValue'] = $this->fieldValue;
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
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldValue'])) {
            $model->fieldValue = $map['fieldValue'];
        }

        return $model;
    }
}
