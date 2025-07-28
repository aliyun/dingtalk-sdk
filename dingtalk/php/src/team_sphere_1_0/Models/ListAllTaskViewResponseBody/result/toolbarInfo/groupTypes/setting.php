<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result\toolbarInfo\groupTypes;

use AlibabaCloud\Tea\Model;

class setting extends Model
{
    /**
     * @var string
     */
    public $dateType;

    /**
     * @var string
     */
    public $fieldName;

    /**
     * @var string
     */
    public $fieldType;
    protected $_name = [
        'dateType' => 'dateType',
        'fieldName' => 'fieldName',
        'fieldType' => 'fieldType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dateType) {
            $res['dateType'] = $this->dateType;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return setting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dateType'])) {
            $model->dateType = $map['dateType'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }

        return $model;
    }
}
