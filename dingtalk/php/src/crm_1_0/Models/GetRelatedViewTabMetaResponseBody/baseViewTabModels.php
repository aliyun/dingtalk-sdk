<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelatedViewTabMetaResponseBody;

use AlibabaCloud\Tea\Model;

class baseViewTabModels extends Model
{
    /**
     * @example PROC-C9EA3AB8-8BCD-4FAD-857D-18D579663366
     *
     * @var string
     */
    public $formCode;

    /**
     * @example OpenDataField_S0RIE8G0YAKG",             "sourceFormUuid": "PROC-C9EA3AB8-8BCD-4FAD-857D-18D579663366
     *
     * @var string
     */
    public $relateComponentId;

    /**
     * @example 楚衣的流程表单1
     *
     * @var string
     */
    public $tabTitle;
    protected $_name = [
        'formCode'          => 'formCode',
        'relateComponentId' => 'relateComponentId',
        'tabTitle'          => 'tabTitle',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->relateComponentId) {
            $res['relateComponentId'] = $this->relateComponentId;
        }
        if (null !== $this->tabTitle) {
            $res['tabTitle'] = $this->tabTitle;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return baseViewTabModels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['relateComponentId'])) {
            $model->relateComponentId = $map['relateComponentId'];
        }
        if (isset($map['tabTitle'])) {
            $model->tabTitle = $map['tabTitle'];
        }

        return $model;
    }
}
