<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result\viewEntityMultiFieldVOList;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result\viewEntityMultiFieldVOList\rowFields\viewEntityFieldList;
use AlibabaCloud\Tea\Model;

class rowFields extends Model
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
     * @var viewEntityFieldList[]
     */
    public $viewEntityFieldList;
    protected $_name = [
        'fieldCode'           => 'fieldCode',
        'fieldName'           => 'fieldName',
        'viewEntityFieldList' => 'viewEntityFieldList',
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
        if (null !== $this->viewEntityFieldList) {
            $res['viewEntityFieldList'] = [];
            if (null !== $this->viewEntityFieldList && \is_array($this->viewEntityFieldList)) {
                $n = 0;
                foreach ($this->viewEntityFieldList as $item) {
                    $res['viewEntityFieldList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rowFields
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
        if (isset($map['viewEntityFieldList'])) {
            if (!empty($map['viewEntityFieldList'])) {
                $model->viewEntityFieldList = [];
                $n                          = 0;
                foreach ($map['viewEntityFieldList'] as $item) {
                    $model->viewEntityFieldList[$n++] = null !== $item ? viewEntityFieldList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
