<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDatasetFieldsResponseBody\result;

use AlibabaCloud\Tea\Model;

class fields extends Model
{
    /**
     * @var string
     */
    public $displayName;

    /**
     * @var string
     */
    public $fieldId;

    /**
     * @var string
     */
    public $fieldType;
    protected $_name = [
        'displayName' => 'displayName',
        'fieldId'     => 'fieldId',
        'fieldType'   => 'fieldType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }

        return $model;
    }
}
