<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelatedViewTabMetaResponseBody;

use AlibabaCloud\Tea\Model;

class results extends Model
{
    /**
     * @example PROC-4EFE895D-A291-4A65-9FD6-99431604DF67
     *
     * @var string
     */
    public $formCode;

    /**
     * @example OpenDataField_K99RPMMRGJ40
     *
     * @var string
     */
    public $relateComponentId;

    /**
     * @example 212
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
     * @return results
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
