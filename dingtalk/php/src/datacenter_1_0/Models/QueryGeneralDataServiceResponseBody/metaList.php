<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceResponseBody;

use AlibabaCloud\Tea\Model;

class metaList extends Model
{
    /**
     * @description 指标名称
     *
     * @var string
     */
    public $fieldDesc;

    /**
     * @description 指标口径
     *
     * @var string
     */
    public $fieldId;

    /**
     * @description 指标ID
     *
     * @var string
     */
    public $fieldName;

    /**
     * @description 指标单位
     *
     * @var string
     */
    public $fieldType;
    protected $_name = [
        'fieldDesc' => 'fieldDesc',
        'fieldId'   => 'fieldId',
        'fieldName' => 'fieldName',
        'fieldType' => 'fieldType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldDesc) {
            $res['fieldDesc'] = $this->fieldDesc;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
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
     * @return metaList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldDesc'])) {
            $model->fieldDesc = $map['fieldDesc'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
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
