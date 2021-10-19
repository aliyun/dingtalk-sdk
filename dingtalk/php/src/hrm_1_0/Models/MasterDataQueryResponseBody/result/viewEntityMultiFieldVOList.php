<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result\viewEntityMultiFieldVOList\rowFields;
use AlibabaCloud\Tea\Model;

class viewEntityMultiFieldVOList extends Model
{
    /**
     * @var string
     */
    public $fieldCode;

    /**
     * @var string
     */
    public $fieldName;

    /**
     * @var string
     */
    public $fieldType;

    /**
     * @var rowFields[]
     */
    public $rowFields;
    protected $_name = [
        'fieldCode' => 'fieldCode',
        'fieldName' => 'fieldName',
        'fieldType' => 'fieldType',
        'rowFields' => 'rowFields',
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
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }
        if (null !== $this->rowFields) {
            $res['rowFields'] = [];
            if (null !== $this->rowFields && \is_array($this->rowFields)) {
                $n = 0;
                foreach ($this->rowFields as $item) {
                    $res['rowFields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return viewEntityMultiFieldVOList
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
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }
        if (isset($map['rowFields'])) {
            if (!empty($map['rowFields'])) {
                $model->rowFields = [];
                $n                = 0;
                foreach ($map['rowFields'] as $item) {
                    $model->rowFields[$n++] = null !== $item ? rowFields::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
