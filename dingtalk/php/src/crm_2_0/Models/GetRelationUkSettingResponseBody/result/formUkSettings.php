<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_2_0\Models\GetRelationUkSettingResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcrm_2_0\Models\GetRelationUkSettingResponseBody\result\formUkSettings\fieldList;
use AlibabaCloud\Tea\Model;

class formUkSettings extends Model
{
    /**
     * @var fieldList[]
     */
    public $fieldList;
    protected $_name = [
        'fieldList' => 'fieldList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldList) {
            $res['fieldList'] = [];
            if (null !== $this->fieldList && \is_array($this->fieldList)) {
                $n = 0;
                foreach ($this->fieldList as $item) {
                    $res['fieldList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return formUkSettings
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldList'])) {
            if (!empty($map['fieldList'])) {
                $model->fieldList = [];
                $n                = 0;
                foreach ($map['fieldList'] as $item) {
                    $model->fieldList[$n++] = null !== $item ? fieldList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
